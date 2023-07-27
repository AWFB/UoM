using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UoM.Blazor.Data;
using UoM.Blazor.Interfaces;
using UoM.Blazor.Models;
using UoM.Blazor.Models.Responses;

namespace UoM.Blazor.Services
{
    public interface IAssayService
    {
        Task<GetAssaysResponse> GetAssaysAsync();
        Task<ResponseBase> AddAssay(IAssayModel assayforCreation);
        Task<GetAssayResponse> GetAssayAsync(int id);
        Task<ResponseBase> DeleteAssay(IAssayModel assay);
        Task<ResponseBase> EditAssay(IAssayModel assayForEdit);
    }

    public class AssayService : IAssayService
    {
        private readonly IDbContextFactory<DataContext> _factory;
        private readonly IMapper _mapper;

        public AssayService(IDbContextFactory<DataContext> factory, IMapper mapper)
        {
            _factory = factory;
            _mapper = mapper;
        }

        public async Task<ResponseBase> AddAssay(IAssayModel assayForCreation)
        {
            var response = new ResponseBase();
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    var assay = _mapper.Map<AssayModel>(assayForCreation);
                    context.Add(assay);
                    var result = await context.SaveChangesAsync();

                    if (result == 1)
                    {
                        response.StatusCode = 200;
                        response.Message = "Assay Created";
                    }
                    else
                    {
                        response.StatusCode = 400;
                        response.Message = "Error occured during assay creation";
                    }
                }  
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = "Error adding assay" + ex.Message;
            }

            return response;
        }

        public async Task<ResponseBase> DeleteAssay(IAssayModel assay)
        {
            var response = new ResponseBase();
            try
            {
                using (var context = _factory.CreateDbContext())
                {                  
                    context.Remove(assay);
                    var result = await context.SaveChangesAsync();

                    if (result == 1)
                    {
                        response.StatusCode = 200;
                        response.Message = "Assay Deleted";
                    }
                    else
                    {
                        response.StatusCode = 400;
                        response.Message = "Error - Unable to delete assay";
                    }
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = "Error deleting assay" + ex.Message;
            }

            return response;
        }
        
        public async Task<ResponseBase> EditAssay(IAssayModel assayForEdit)
        {
            var response = new ResponseBase();
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    var assay = _mapper.Map<AssayModel>(assayForEdit);
                    context.Update(assay);
                    var result = await context.SaveChangesAsync();

                    if (result == 1)
                    {
                        response.StatusCode = 200;
                        response.Message = "Assay Updated";
                    }
                    else
                    {
                        response.StatusCode = 400;
                        response.Message = "Error occured during assay update";
                    }
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = "Error updating assay" + ex.Message;
            }

            return response;
        }

        public async Task<GetAssayResponse> GetAssayAsync(int id)
        {
            var response = new GetAssayResponse();

            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    var assay = await context.Assays.FirstOrDefaultAsync(x => x.AssayId == id);
                    response.Assay = assay;
                    response.StatusCode = 200;
                    response.Message = "OK";
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = "Error fecting Assays:" + ex.Message;
                response.Assay = null;
            }

            return response;
        }

        public async Task<GetAssaysResponse> GetAssaysAsync()
        {
            var response = new GetAssaysResponse();

            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    var assays = await context.Assays.ToListAsync();
                    response.Assays = assays;
                    response.StatusCode = 200;
                    response.Message = "OK";
                }
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = "Error fecting Assays:" + ex.Message;
                response.Assays = null;
            }

            return response;

        }
    }
}
