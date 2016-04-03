using IB23_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;

namespace IB23_2
{
    public class Shedule
    {
        private System.Threading.Thread thr;
        private System.Threading.ManualResetEvent mse = new System.Threading.ManualResetEvent(false);

        public Shedule()
        {
            thr = new System.Threading.Thread(new ThreadStart(mainThread));
        }

        public void Start()
        {
            thr.Start();
        }
        public void mainThread()
        {
            IbDbContext db = new IbDbContext();
            do
            {
                var number = db.Cycles.Select(x => x.Number).ToList().LastOrDefault();
                db.Cycles.Add(new Cycles(++number));
                db.SaveChanges();
            } while (!this.mse.WaitOne(20 * 60 * 1000, false));
        }
    }
}