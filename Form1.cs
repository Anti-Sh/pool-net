using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pool_net
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.OpenConnection();
            
            tcMain_SelectedIndexChanged(sender, e);
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            switch (tcMain.SelectedIndex)
            {
                case 0:
                    query = "SELECT `a`.`id`, CONCAT_WS(\" \", `p`.`second_name`, `p`.`first_name`, `p`.`father_name`), `t`.`name`, `a`.`days_per_week`, `a`.`start_date`, `a`.`cost` FROM `abonnements` `a` INNER JOIN `persons` `p` ON `a`.`person_id`=`p`.`id` INNER JOIN `tariffs` `t` ON `a`.`tariff_id`=`t`.`id` WHERE `a`.`start_date`<=CURRENT_DATE() AND `a`.`start_date`>=CURRENT_DATE()-INTERVAL 7 DAY ORDER BY `a`.`cost` LIMIT 1;";
                    var result = DB.ExecuteQuery(query, 6);
                    dgQuery1.Rows.Clear();
                    foreach (string[] row in result)
                        dgQuery1.Rows.Add(row);
                    
                    break;
                case 1:
                    query = "SELECT `a`.`id`, CONCAT_WS(' ', `p`.`second_name`, `p`.`first_name`, `p`.`father_name`), `t`.`name`, `a`.`days_per_week`, `a`.`start_date`, `a`.`cost` FROM `abonnements` `a` INNER JOIN `persons` `p` ON `a`.`person_id`=`p`.`id` INNER JOIN `tariffs` `t` ON `a`.`tariff_id`=`t`.`id` WHERE `a`.`days_per_week`=2;";
                    var result2 = DB.ExecuteQuery(query, 6);
                    dgQuery2.Rows.Clear();
                    foreach (string[] row in result2)
                        dgQuery2.Rows.Add(row);
                    break;
                case 2:
                    query = "SELECT AVG(`a`.`cost` / ((`t`.`days` / 7) * `a`.`days_per_week` )) FROM `abonnements` `a` INNER JOIN `tariffs` `t` ON `a`.`tariff_id`=`t`.`id` WHERE NOT `a`.`tariff_id`='1';";
                    tbQuery3Result.Text = Math.Round(Convert.ToDouble(DB.ExecuteQuery(query)), 2).ToString();
                    break;
            }

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.CloseConnection();
        }
    }
}
