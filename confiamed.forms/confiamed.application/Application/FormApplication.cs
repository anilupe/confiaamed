using Confiamed.Application.Application.Dto;
using Confiamed.Domain.Entity;
using Confiamed.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confiamed.Application.Business
{
    public class FormApplication
    {
        private readonly IRepository<Form,int> _repository;
        private readonly IRepository<FormDetail, int> _repositoryDetail;

        public FormApplication(IRepository<Form, int> repository, IRepository<FormDetail, int> repositoryDetail)
        {
            _repository = repository;
            _repositoryDetail = repositoryDetail;
        }

        public async Task<List<FormAndDetailDto>> Get()
        {
            var response = new  List<FormAndDetailDto>();

           var result = (await  _repository.GetAllListAsync()).ToList();


            foreach (var item in result)
            {
                response.Add(
                    new FormAndDetailDto
                    {
                        Form = item,
                        FormDetail=_repositoryDetail.GetAll().Where(c=>c.FormId==item.Id).ToList()

                    });
            }
            return response;
        }

    }
}
