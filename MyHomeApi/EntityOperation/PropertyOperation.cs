using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyHomeApi.Context;


namespace MyHomeApi.EntityOperation
{
    public class PropertyOperation
    {

        public PropertyViewModel AddProperty(PropertyViewModel newProperty)
        {
            MyHomeDBContext context = new MyHomeDBContext();
            var prop = new Property()
            {
                PropertyId = newProperty.PropertyId,
                GroupLogoUrl = newProperty.GroupLogoUrl,
                BedsString = newProperty.BedsString,
                Price = newProperty.Price,
                SizeStringMeters = newProperty.SizeStringMeters,
                DisplayAddress = newProperty.DisplayAddress,
                PropertyType = newProperty.PropertyType,
                BathString = newProperty.BathString,
                BerRating = newProperty.BerRating,
                MainPhoto = newProperty.MainPhoto,
                Photo = new Photo() { DataPhoto = newProperty.Photos }
            };
            context.Properties.Add(prop);
            context.SaveChanges();
            return newProperty;
        }

        public List<Property> GetPropertyList()
        {
            MyHomeDBContext context = new MyHomeDBContext();
            List<Property> propertyList = new List<Property>();
            propertyList = context.Properties.ToList();
            return propertyList;
        }

        
        public Boolean DeleteProperty(Int32 id)
        {
            MyHomeDBContext context = new MyHomeDBContext();
            Property prop = new Property();
            prop = context.Properties.Where(x => x.PropertyId == id).FirstOrDefault();
            context.Properties.Remove(prop);
            context.SaveChanges();
            return true;
        }

        public Property GetPropertyById(Int32 id)
        {
            MyHomeDBContext context = new MyHomeDBContext();

            var prop = context.Properties.Where(x => x.PropertyId == id).FirstOrDefault();

            return prop;

        }


    }
}