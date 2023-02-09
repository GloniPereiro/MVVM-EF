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
    public class ListaProduktowCrudServices : ICrud
    {
        private readonly IDataService<ListaProduktow> _crudServices;

        public ListaProduktowCrudServices()
        {
            _crudServices = new GenericDataService<ListaProduktow>(new ProductContextFactory());
        }

        public async Task<ListaProduktow> AddBrand(string name, string number)
        {
            try
            {
                if (name == string.Empty)
                {
                    throw new Exception("Student Name Cannot be Empty");
                }
                else
                {
                    ListaProduktow br = new ListaProduktow
                    {
                        Produkt = name,
                        Kod = number,
                        DataUtworzenia = DateTime.Now,
                        IloscZmian = 1
                    };
                    return await _crudServices.Create(br);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteBrand(int id)
        {
            try
            {
                ListaProduktow delete = await SearchBrandbyID(id);

                return await _crudServices.Delete(delete);



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<ICollection<ListaProduktow>> ListBrands()
        {
            try
            {
                return (ICollection<ListaProduktow>)await _crudServices.GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Task<ListaProduktow> SearchBrandbyID(int ID)
        {
            try
            {
                return _crudServices.Get(ID);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<ICollection<ListaProduktow>> SearchBrandByName(string name)
        {
            try
            {
                var listbrand = await ListBrands();
                return listbrand.Where(x => x.Produkt.StartsWith(name)).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public async Task<ListaProduktow> UpdateBrand(int id, string name, string number)
        {
            try
            {
                ListaProduktow br = await SearchBrandbyID(id);
                br.Kod = number;
                br.IloscZmian += 1;
                return await _crudServices.Update(br);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
    }
}
