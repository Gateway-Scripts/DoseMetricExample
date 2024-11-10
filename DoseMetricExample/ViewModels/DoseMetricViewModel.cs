using DoseMetricExample.Helpers;
using DoseMetricExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoseMetricExample.ViewModels
{
    public class DoseMetricViewModel
    {
        private EventHelper _eventHelper;

        //private IEventAggregator _eventAggregator;

        public ObservableCollection<DoseMetricModel> DoseMetrics { get; private set; }
        public DoseMetricViewModel(EventHelper eventHelper)//IEventAggregator eventAggregator )
        {
            //_eventAggregator = eventAggregator;
            _eventHelper = eventHelper;
            DoseMetrics = new ObservableCollection<DoseMetricModel>();
            //_eventAggregator.GetEvent<AddDoseMetricEvent>().Subscribe(OnAddMetric);
            _eventHelper.Subscribe<DoseMetricModel>("AddDoseMetricEvent", OnAddMetric);
        }

        private void OnAddMetric(DoseMetricModel obj)
        {
            DoseMetrics.Add(obj);
        }
    }
}
