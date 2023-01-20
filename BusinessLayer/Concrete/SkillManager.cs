using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        private EfSkillDal _efSkillDal;
        public SkillManager(EfSkillDal efSkillDall)
        {
            _efSkillDal = efSkillDall;
        }

        public void TAdd(Skill entity)
        {
            _efSkillDal.Insert(entity);
        }

        public void TDelete(Skill entity)
        {
            _efSkillDal.Delete(entity);
        }

        public Skill TGetById(int id)
        {
           return _efSkillDal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _efSkillDal.GetAll();
        }

        public void TUpdate(Skill entity)
        {
            _efSkillDal.Update(entity);
        }
    }
}
