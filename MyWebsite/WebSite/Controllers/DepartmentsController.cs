using AppService;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class DepartmentsController:BaseController
    {
        IDepartmentService departmentService;
        public DepartmentsController(IDepartmentService departmentService)
        {
            this.departmentService=departmentService;
        }

        [HttpGet]
        public ActionResult<List<DepartmentsDTO>> GetAll()
        {
            var departmentsList = departmentService.GetList();
            if (departmentsList.Count == 0)
            {
                return BadRequest();
            }
            return Ok(departmentsList);
        }

        [HttpGet("{Id}")]
        public ActionResult<DepartmentsDTO> GetById(int Id)
        {
            var department = departmentService.GetById(Id);
            if (department == null)
            {
                return BadRequest();
            }
            return Ok(department);
        }

        [HttpPost] //create a new obj
        //[Authorize]
        public ActionResult Create(DepartmentsDTO departmentsDTO)
        {
            if (departmentsDTO != null)
            {
                departmentService.Create(departmentsDTO);
                return Ok();
            }
            return BadRequest();
        }


        [HttpPut] //create a new obj
        public ActionResult Update(DepartmentsDTO departmentsDTO)
        {
            if (departmentsDTO != null)
            {
                departmentService.Create(departmentsDTO);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            if (Id != null)
            {
                departmentService.Delete(Id);
                return Ok();

            }
            return BadRequest();
        }
    }
}
