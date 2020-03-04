using Domaine;
using MapLevio.Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
  public  class ServiceResource : Service<resource>, IserviceResource
    {
        private static IDatabaseFactory dbfactory = new DatabaseFactory();
        private static IUnitOfWork UOW = new UnitOfWork(dbfactory);
        public ServiceResource() : base(UOW)
        {
        }
    }
}
