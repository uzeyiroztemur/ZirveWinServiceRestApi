using System.ServiceProcess;

namespace ZirveWinService.Service
{
    public partial class ZirveWinService : ServiceBase
    {
        public ZirveWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {

        }
    }
}
