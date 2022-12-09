using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Abstract.Bases;
using DataAccess.Abstract;
using DataAccess.Abstract.Bases;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }

        public List<Feature> GetList()
        {
            return _featureDal.GetList();
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }
    }
}
