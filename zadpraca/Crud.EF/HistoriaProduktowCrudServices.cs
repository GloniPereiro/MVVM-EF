using Crud.domain.Model;
using Crud.domain.Services;
using Crud.EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.EF
{
    public class HistoriaProduktowCrudServices : ICrud
    {
        private readonly IDataService<HistoriaProduktow> _HistoryServices;

        public HistoriaProduktowCrudServices()
        {
            _HistoryServices = new GenericDataService<HistoriaProduktow>(new ProductContextFactory());
        }

        public async Task<HistoriaProduktow> AddHistoryBrand(string name, string number)
        {
            try
            {
                if (name == string.Empty)
                {
                    throw new Exception("Student Name Cannot be Empty");
                }
                else
                {
                    HistoriaProduktow br = new HistoriaProduktow
                    {
                        Produkt = name,
                        StaryKod = number,
                        DataZmiany = DateTime.Now

                    };
                    return await _HistoryServices.Create(br);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteHistoryBrand(int id)
        {
            try
            {
                HistoriaProduktow delete = await SearchHistoryBrandbyID(id);

                return await _HistoryServices.Delete(delete);



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<ICollection<HistoriaProduktow>> ListHistoryBrands()
        {
            try
            {
                return (ICollection<HistoriaProduktow>)await _HistoryServices.GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Task<HistoriaProduktow> SearchHistoryBrandbyID(int ID)
        {
            try
            {
                return _HistoryServices.Get(ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<HistoriaProduktow>> SearchHistoryBrandByName(string name)
        {
            try
            {
                var listhistorybrand = await ListHistoryBrands();
                return listhistorybrand.Where(x => x.Produkt.StartsWith(name)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public async Task<HistoriaProduktow> UpdateBrand(int id, string name, string number)
        {
            try
            {
                HistoriaProduktow br = await SearchHistoryBrandbyID(id);
                br.Produkt = name;
                return await _HistoryServices.Update(br);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
    }
}
