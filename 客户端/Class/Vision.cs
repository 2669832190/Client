using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九点标定
{
    public class Vision
    {
        //标定的TB
        public CogToolBlock NPointTB;
        //相机
        public CogAcqFifoTool FifoTool;

		/// <summary>
		/// 下相机NPointVPP
		/// </summary>
		public CogToolBlock DownCameraNpointTB { get; set; }

		private string NPointTB_path = Directory.GetCurrentDirectory() + "\\vpp\\NPoint.vpp";
        private string FifoTool_path = Directory.GetCurrentDirectory() + "\\vpp\\CamFifo.vpp";

        public void Load()
        {
            NPointTB = CogSerializer.LoadObjectFromFile(NPointTB_path) as CogToolBlock;
            FifoTool = CogSerializer.LoadObjectFromFile(FifoTool_path) as CogAcqFifoTool;
        }
		/// <summary>
		/// 保存检测Vpp
		/// </summary>
		/// <returns></returns>
		public bool SaveTB() {
			try {
				//CogSerializer.SaveObjectToFile(InsepectionTB, _inspectTBPath);
				//CogSerializer.SaveObjectToFile(DownCameraTB , _downTBPath);
				//CogSerializer.SaveObjectToFile(RecheckTB , _recheckTBPath);
				//CogSerializer.SaveObjectToFile(RecheckTB , _recheckTBPath);
				return true;

			} catch ( Exception ) {

				return false;
			}
		}
	}
}
