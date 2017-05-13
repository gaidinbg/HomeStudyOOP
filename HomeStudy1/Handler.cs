using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeStudy1
{
    class Handler
    {
        private IIntroducable entity;

        public IIntroducable Entity
        {
            get { return entity; }
            set { entity = value; }

        }

        public Handler (IIntroducable entity)
        {
            this.Entity = entity;
        }

         public void MakeItTalk()
        {
            Console.WriteLine("---------------Behold-----------");
            Entity.IntroduceYourself();
            Console.WriteLine("---------------Behold-----------");
        }
    }
}
