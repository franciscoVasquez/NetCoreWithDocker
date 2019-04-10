using EFCoreCodeFirstSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerCourtReserve.Business
{
    public class CourtContext: ICourtContext
    {
        private CourtReserveContext context;

        public CourtContext(CourtReserveContext context)
        {
            this.context = context;
        }
        public List<Court> GetCourtInfo()
        {
            return context.Court.ToList();
        }

    }
}
