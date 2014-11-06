using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyStart.Modules
{
    public class CarModule: NancyModule
    {
        public CarModule()
        {
            Get["/"] = _ => "Hello World";

            Get["/car/{id}"] = parameters =>
            {
                int id = parameters.id;

                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithModel(id);
            };

            Get["/{make}/{model}"] = _ =>
            {

                var list =  new List<Car>
                {
                    new Car{Id = 1, Make = _.make, Model = _.Model}
                    ,new Car{Id = 2, Make = _.make, Model = _.Model}
                    ,new Car{Id = 3, Make = _.make, Model = _.Model}
                    ,new Car{Id = 4, Make = _.make, Model = _.Model}
                    ,new Car{Id = 5, Make = _.make, Model = _.Model}
                    ,new Car{Id = 6, Make = _.make, Model = _.Model}
                    ,new Car{Id = 7, Make = _.make, Model = _.Model}
                    ,new Car{Id = 8, Make = _.make, Model = _.Model}
                    ,new Car{Id = 9, Make = _.make, Model = _.Model}
                    ,new Car{Id = 10, Make = _.make, Model = _.Model}
                    ,new Car{Id = 11, Make = _.make, Model = _.Model}
                    ,new Car{Id = 12, Make = _.make, Model = _.Model}
                    ,new Car{Id = 13, Make = _.make, Model = _.Model}
                    ,new Car{Id = 14, Make = _.make, Model = _.Model}
                    ,new Car{Id = 15, Make = _.make, Model = _.Model}
                };

                return Negotiate
                    .WithStatusCode(HttpStatusCode.OK)
                    .WithModel(list);
            };
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}