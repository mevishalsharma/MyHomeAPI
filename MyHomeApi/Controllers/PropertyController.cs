using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using MyHomeApi.EntityOperation;

namespace MyHomeApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PropertyController : ApiController
    {
        public IHttpActionResult GetPropertyList() 
        {
            PropertyOperation propertyOperation = new PropertyOperation();
            return Ok(propertyOperation.GetPropertyList());
        }


        public IHttpActionResult GetPropertyById(Int32 id)  
        {
            PropertyOperation propertyOperation = new PropertyOperation();
            var data = propertyOperation.GetPropertyById(id);
            if(data==null)
            {
                return Content(HttpStatusCode.NotFound, "Property not found");
            }
            return Ok(data);
        }

        
        [HttpDelete]
        public IHttpActionResult Delete(Int32 id) 
        {
            PropertyOperation propertyOperation = new PropertyOperation();
            var data = propertyOperation.DeleteProperty(id);
            return Ok(data);
        }

        [HttpPost]
        public PropertyViewModel AddNewProperty(PropertyViewModel newProperty)
        {
            PropertyOperation propertyOperation = new PropertyOperation();
            return propertyOperation.AddProperty(newProperty);
        }

        //public IEnumerable<Property> GetPropertyList()
        //{
        //    PropertyOperation propertyOperation = new PropertyOperation();
        //    return  propertyOperation.GetPropertyList();
        //}







        //public Property GetPropertyById(Int32 id)
        //{
        //    //Int32 propId = id == null ? (int)id : 0;
        //    PropertyOperation propertyOperation = new PropertyOperation();
        //    return  propertyOperation.GetPropertyById(id);
        //}
    }
}
