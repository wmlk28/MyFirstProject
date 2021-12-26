using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic paraa = new ExpandoObject();

            // 业务id
            paraa.BUSINESS_ID = "111";
             
            // 0:新闻   1：日程    等等
            paraa.MODULETYPE = "0";

            // 0:新增   1:修改   2:删除
            paraa.JOBTYPE = "0";
             
            // 传递的参数集合
            dynamic par_data = new ExpandoObject();
            par_data.id = "编号";
            par_data.name = "名称标题";
            paraa.REQUESTDATA = JsonConvert.SerializeObject(par_data);

            // 机构Id集合
            paraa.ORGANIZATIONS = new List<string>() { "1", "2" }; 


            var jsonBody = JsonConvert.SerializeObject(paraa);


            Post_Mvp("http://localhost:4235/JobSchedual/Job", jsonBody);
        }
         

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic paraa = new ExpandoObject();

            // 业务id
            paraa.BUSINESS_ID = "222";
             
            // 0:新闻   
            paraa.MODULETYPE = "0";

            // 0:新增   1:修改   2:删除
            paraa.JOBTYPE = "1";

            // 传递的参数集合
            dynamic par_data = new ExpandoObject();
            par_data.id = "222";
            paraa.REQUESTDATA = JsonConvert.SerializeObject(par_data);

            // 机构集合
            paraa.ORGANIZATIONS = new List<string>() { "1", "2" };

            var jsonBody = JsonConvert.SerializeObject(paraa);


            Post_Mvp("http://localhost:4235/JobSchedual/Job", jsonBody);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            dynamic paraa = new ExpandoObject();

            // 业务id
            paraa.BUSINESS_ID = "333";

            // 0:新闻   
            paraa.MODULETYPE = "0";

            // 0:新增   1:修改   2:删除
            paraa.JOBTYPE = "2";

            // 传递的参数集合
            dynamic par_data = new ExpandoObject();
            par_data.id = "333";
            paraa.REQUESTDATA = JsonConvert.SerializeObject(par_data);

            // 机构集合
            paraa.ORGANIZATIONS = new List<string>() { "1", "2" };

            var jsonBody = JsonConvert.SerializeObject(paraa);


            Post_Mvp("http://localhost:4235/JobSchedual/Job", jsonBody);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEXECTYPE.SelectedIndex = 0;
            cmbEXECISINTERVAL.SelectedIndex = 1;

            groupBox3.Visible = true;
            groupBox3.Location = new Point(28, 85);

            groupBox6.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEXECTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEXECTYPE.SelectedIndex)
            {
                case 0:
                    {
                        groupBox3.Visible = true;
                        groupBox3.Location = new Point(28, 85);

                        groupBox6.Visible = false;
                        groupBox4.Visible = false;
                        groupBox5.Visible = false; 

                        break;
                    }

                case 1:
                    {
                        groupBox4.Visible = true;
                        groupBox4.Location = new Point(28, 85);

                        groupBox6.Visible = false;
                        groupBox3.Visible = false;
                        groupBox5.Visible = false;

                        break;
                    }

                case 2:
                    {
                        groupBox5.Visible = true;
                        groupBox5.Location = new Point(28, 85);

                        groupBox6.Visible = false;
                        groupBox3.Visible = false;
                        groupBox4.Visible = false;

                        break;
                    }

                case 3:
                    {
                        groupBox6.Visible = true;
                        groupBox6.Location = new Point(28, 85);

                        groupBox5.Visible = false;
                        groupBox3.Visible = false;
                        groupBox4.Visible = false;

                        break;
                    }

            }
        }



        /// <summary>
        /// 定时任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            dynamic paraa = new ExpandoObject();

            // 业务id
            paraa.BUSINESS_ID = "666";

            // 任务类型  0:系统任务   1:业务任务（运行完成之后自动删除任务）
            paraa.TASKTYPE = "0";
            // CRON表达式
            paraa.CRONEXPRESS = txtCRONEXPRESS.Text.Trim();

            // 0:新闻   
            paraa.MODULETYPE = "0";

            // 0:新增   1:修改   2:删除
            paraa.JOBTYPE = "2";

            // 传递的参数集合
            dynamic par_data = new ExpandoObject();
            par_data.id = "666";
            paraa.REQUESTDATA = JsonConvert.SerializeObject(par_data);

            // 机构集合
            paraa.ORGANIZATIONS = new List<string>() { "1", "2" };



            paraa.EXECTYPE = cmbEXECTYPE.Text.ToString();
            paraa.CRONDAY = txtCRONDAY.Text.Trim();
            paraa.CRONDAYWEEK = txtCRONDAYWEEK.Text.Trim();
            paraa.CRONDAYMONTH = txtCRONDAYMONTH.Text.Trim();
            paraa.CRONMONTH = txtCRONMONTH.Text.Trim();
            paraa.EXECISINTERVAL = cmbEXECISINTERVAL.SelectedIndex.ToString();
            paraa.CRONHOUR = txtCRONHOUR.Text.Trim();
            paraa.CRONMINTS = txtCRONMINTS.Text.Trim();
            paraa.CRONSECDS = txtCRONSECDS.Text.Trim();

            var jsonBody = JsonConvert.SerializeObject(paraa);


            Post_Mvp("http://localhost:4235/JobSchedual/Job", jsonBody);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="tokenId"></param>
        /// <param name="time"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static string Post_Mvp(string url, string param, string tokenId = "", int time = 60000, string contentType = "application/json;charset=utf-8")
        {
            // 强制回收垃圾
            try
            {
                System.GC.Collect();
            }
            catch { }

            Uri requestUri = new Uri(url);
            HttpWebRequest httpWebRequest = WebRequest.Create(requestUri) as HttpWebRequest;
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = contentType;
            httpWebRequest.Timeout = time;
            byte[] bytes = Encoding.UTF8.GetBytes((param == null) ? "" : param);
            httpWebRequest.ContentLength = (long)bytes.Length;

            //这个在Post的时候，一定要加上，如果服务器返回错误，他还会继续再去请求，不会使用之前的错误数据，做返回数据
            httpWebRequest.ServicePoint.Expect100Continue = false;
            httpWebRequest.KeepAlive = false;
            ServicePointManager.DefaultConnectionLimit = 80; //这个值默认是2，根据自己的情况修改

            //ServicePointManager.Expect100Continue = false;

            if (!string.IsNullOrEmpty(tokenId))
            {
                string str = string.Empty;
                string text = string.Empty;
                text = (string.IsNullOrEmpty(text) ? "" : text);
                httpWebRequest.Headers.Add("Authorization", "Basic ");
            }
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }
            string result = "";
            using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                result = streamReader.ReadToEnd();
            }

            // 如果是一次性的接口（例如：数据广发的那种，最多重新运行两次，如果，还是失败，就不再运行）
            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        { 
            Post_Mvp("http://localhost:4235/JobSchedual/DelJobTask?businessId=" + this.txtId.Text.Trim(), "");
        }
    }
}
