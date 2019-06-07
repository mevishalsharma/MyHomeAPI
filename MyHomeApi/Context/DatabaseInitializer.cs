using System.Data.Entity;

namespace MyHomeApi.Context
{
    public class DatabaseInitializerEF<T> : CreateDatabaseIfNotExists<MyHomeDBContext>
    {
        protected override void Seed(MyHomeDBContext context)
        {

            var propEntity = new Property
            {
                PropertyId = 4292232,
                GroupLogoUrl = "https://photos-a.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                BedsString = "2	beds",
                Price = 395000,
                SizeStringMeters = 52.95,
                DisplayAddress = "Apt.	16	The	Northumberlands,	Off	Lower	Mount	Street,Dublin	2",
                PropertyType = "Apartment",
                BerRating = "D2",
                BathString="2 Bath",
                MainPhoto = "https://photos-a.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                Photo = new Photo { DataPhoto = "https://photos-a.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg" }

            };

            context.Properties.Add(propEntity);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}