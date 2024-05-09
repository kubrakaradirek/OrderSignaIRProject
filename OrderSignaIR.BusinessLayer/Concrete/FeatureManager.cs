using OrderSignaIR.BusinessLayer.Abstract;
using OrderSignaIR.DataAccessLayer.Abstract;
using OrderSignaIR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.BusinessLayer.Concrete
{
    public class FeatureManager:IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature entity)
        {
            _featureDal.Add(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureDal.GetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
