using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Visualisation_of_production_indices.Models;

namespace Visualisation_of_production_indices.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> OnGetAsync()
        {

            string d1 = await Day1();
            string d2 = await Day2();
            string p = await PCycle();
            string t = await TCycle();
            string p21 = await P2_1();
            string t22 = await T2_2();
            string Infop31 = await Showp31();
            string Infop32 = await Showp32();
            string usInfo = await Showp33();
            string create = await ShowCreated();

            double pc = Convert.ToDouble(p);
            double tc = Convert.ToDouble(t);
            double w = tc / pc * 100;
            ViewData["Percentage"] = Math.Round(w, 1);

            double pcy = Convert.ToDouble(p21);
            double tcy = Convert.ToDouble(t22);
            double wy = tcy / pcy * 100;
            ViewData["PercentageYear"] = Math.Round(wy, 1);

            string P41 = await Showp41();
            string P42 = await Showp42();
            string P43 = await Showp43();
            string P51 = await Showp51();
            string P52 = await Showp52();
            string P53 = await Showp53();
            string P61 = await Showp61();
            string P62 = await Showp62();
            string P63 = await Showp63();
            string P71 = await Showp71();
            string P72 = await Showp72();
            string P73 = await Showp73();
            string P74 = await Showp74();
            string P75 = await Showp75();
            //ViewData["p75"] = P75;
            string P81 = await Showp81();
            string P82 = await Showp82();
            string P83 = await Showp83();
            string P84 = await Showp84();
            string P85 = await Showp85();
            string P111 = await Showp111();
            string P112 = await Showp112();
            string P113 = await Showp113();

            double param53 = Convert.ToDouble(P53);
            double param63 = Convert.ToDouble(P63);
            int day2 = Convert.ToInt32(d2);
            double Negative_advance = (param63 - param53) * day2 / param63;
            ViewData["negative_advance"] = Math.Round(Negative_advance, 1);

            int day1 = Convert.ToInt32(d1);
            double param33 = Convert.ToDouble(usInfo);
            double param43 = Convert.ToDouble(P43);
            double Neg_adv_current = (param43 - param33) * day1 / param43;
            ViewData["neg_adv_current"] = Math.Round(Neg_adv_current, 1);
            ViewData["p43"] = Math.Round(param43 / 1000, 1);
            ViewData["p63"] = Math.Round(param63 / 1000, 1);

            int param71 = Convert.ToInt32(P71);
            int param72 = Convert.ToInt32(P72);
            double param73 = Convert.ToDouble(P73);
            int waybill_sheet = param72 / param71;
            ViewData["waybill"] = waybill_sheet;
            double quantity_per_one_waybillsheet = param73 / param71;
            ViewData["quantity_per_onewaybill"] = Math.Round(quantity_per_one_waybillsheet / 1000, 1);
            DateTime Curdate = DateTime.Now;
            ViewData["curdate"] = Curdate;

            double param75 = Convert.ToDouble(P75) / 1000;
            double par72 = Convert.ToDouble(P72) / 1000;
            double param74 = Convert.ToDouble(P74) / 1000;
            ViewData["p74"] = Math.Round(param74, 1);
            ViewData["p72"] = Math.Round(par72, 1);
            ViewData["p75"] = Math.Round(param75, 1);
            double param81 = Convert.ToDouble(P81);
            double param82 = Convert.ToDouble(P82) / 1000;
            double param83 = Convert.ToDouble(P83) / 1000;
            double param84 = Convert.ToDouble(P84) / 1000;
            double param85 = Convert.ToDouble(P85) / 1000;
            ViewData["p81"] = Math.Round(param81, 1);
            ViewData["p82"] = Math.Round(param82, 1);
            ViewData["p83"] = Math.Round(param83, 1);
            ViewData["p84"] = Math.Round(param84, 1);
            ViewData["p85"] = Math.Round(param85, 1);
            double param113 = Convert.ToDouble(P113) / 1000;
            ViewData["p113"] = Math.Round(param113, 1);

            string best_name = await ShowUs1name();
            string best_time = await ShowUs1time();
            string best_name2 = await ShowUs2name();
            string best_time2 = await ShowUs2time();
            string best_name3 = await ShowUs3name();
            string best_time3 = await ShowUs3time();
            string best_name4 = await ShowUs4name();
            string best_time4 = await ShowUs4time();
            string best_name5 = await ShowUs5name();
            string best_time5 = await ShowUs5time();
            string best_name6 = await ShowUs6name();
            string best_time6 = await ShowUs6time();
            string best_name7 = await ShowUs7name();
            string best_time7 = await ShowUs7time();
            string best_name8 = await ShowUs8name();
            string best_time8 = await ShowUs8time();
            string best_name9 = await ShowUs9name();
            string best_time9 = await ShowUs9time();
            string best_name10 = await ShowUs10name();
            string best_time10 = await ShowUs10time();

            string best_name_month = await ShowUs1nameBest();
            string best_time_month = await ShowUs1timeBest();
            string best_name2_month = await ShowUs2nameBest();
            string best_time2_month = await ShowUs2timeBest();
            string best_name3_month = await ShowUs3nameBest();
            string best_time3_month = await ShowUs3timeBest();
            string best_name4_month = await ShowUs4nameBest();
            string best_time4_month = await ShowUs4timeBest();
            string best_name5_month = await ShowUs5nameBest();
            string best_time5_month = await ShowUs5timeBest();
            string best_name6_month = await ShowUs6nameBest();
            string best_time6_month = await ShowUs6timeBest();
            string best_name7_month = await ShowUs7nameBest();
            string best_time7_month = await ShowUs7timeBest();
            string best_name8_month = await ShowUs8nameBest();
            string best_time8_month = await ShowUs8timeBest();
            string best_name9_month = await ShowUs9nameBest();
            string best_time9_month = await ShowUs9timeBest();
            string best_name10_month = await ShowUs10nameBest();
            string best_time10_month = await ShowUs10timeBest();

            double best_time_cur_d = Convert.ToDouble(best_time);
            ViewData["best_time_cur"] = Math.Round(best_time_cur_d / 1, 1);
            double best_time_cur_d2 = Convert.ToDouble(best_time2);
            ViewData["best_time_cur2"] = Math.Round(best_time_cur_d2 / 1, 1);
            double best_time_cur_d3 = Convert.ToDouble(best_time3);
            ViewData["best_time_cur3"] = Math.Round(best_time_cur_d3 / 1, 1);
            double best_time_cur_d4 = Convert.ToDouble(best_time4);
            ViewData["best_time_cur4"] = Math.Round(best_time_cur_d4 / 1, 1);
            double best_time_cur_d5 = Convert.ToDouble(best_time5);
            ViewData["best_time_cur5"] = Math.Round(best_time_cur_d5 / 1, 1);
            double best_t_6 = Convert.ToDouble(best_time6);
            ViewData["best_time_cur6"] = Math.Round(best_t_6 / 1, 1);
            double best_time_cur_d7 = Convert.ToDouble(best_time7);
            ViewData["best_time_cur7"] = Math.Round(best_time_cur_d7 / 1, 1);
            double best_time_cur_d8 = Convert.ToDouble(best_time8);
            ViewData["best_time_cur8"] = Math.Round(best_time_cur_d8 / 1, 1);
            double best_time_cur_d9 = Convert.ToDouble(best_time9);
            ViewData["best_time_cur9"] = Math.Round(best_time_cur_d9 / 1, 1);
            double best_time_cur_d10 = Convert.ToDouble(best_time10);
            ViewData["best_time_cur10"] = Math.Round(best_time_cur_d10 / 1, 1);

            ViewData["best_time_c1"] = Math.Round(best_time_cur_d / 1000, 1);
            ViewData["best_time_c2"] = Math.Round(best_time_cur_d2 / 1000, 1);
            ViewData["best_time_c3"] = Math.Round(best_time_cur_d3 / 1000, 1);
            ViewData["best_time_c4"] = Math.Round(best_time_cur_d4 / 1000, 1);
            ViewData["best_time_c5"] = Math.Round(best_time_cur_d5 / 1000, 1);
            ViewData["best_time_c6"] = Math.Round(best_t_6 / 1000, 1);
            ViewData["best_time_c7"] = Math.Round(best_time_cur_d7 / 1000, 1);
            ViewData["best_time_c8"] = Math.Round(best_time_cur_d8 / 1000, 1);
            ViewData["best_time_c9"] = Math.Round(best_time_cur_d9 / 1000, 1);
            ViewData["best_time_c10"] = Math.Round(best_time_cur_d10 / 1000, 1);


            double best_time_month_d = Convert.ToDouble(best_time_month);
            ViewData["best_time_month"] = Math.Round(best_time_month_d / 1000, 1);
            double best_time2_month_d = Convert.ToDouble(best_time2_month);
            ViewData["best_time_month2"] = Math.Round(best_time2_month_d / 1000, 1);
            double best_time3_month_d = Convert.ToDouble(best_time3_month);
            ViewData["best_time_month3"] = Math.Round(best_time3_month_d / 1000, 1);
            double best_time4_month_d = Convert.ToDouble(best_time4_month);
            ViewData["best_time_month4"] = Math.Round(best_time4_month_d / 1000, 1);
            double best_time5_month_d = Convert.ToDouble(best_time5_month);
            ViewData["best_time_month5"] = Math.Round(best_time5_month_d / 1000, 1);
            double best_time6_month_d = Convert.ToDouble(best_time6_month);
            ViewData["best_time_month6"] = Math.Round(best_time6_month_d / 1000, 1);
            double best_time7_month_d = Convert.ToDouble(best_time7_month);
            ViewData["best_time_month7"] = Math.Round(best_time7_month_d / 1000, 1);
            double best_time8_month_d = Convert.ToDouble(best_time8_month);
            ViewData["best_time_month8"] = Math.Round(best_time8_month_d / 1000, 1);
            double best_time9_month_d = Convert.ToDouble(best_time9_month);
            ViewData["best_time_month9"] = Math.Round(best_time9_month_d / 1000, 1);
            double best_time10_month_d = Convert.ToDouble(best_time10_month);
            ViewData["best_time_month10"] = Math.Round(best_time10_month_d / 1000, 1);

            string[] param_value = { d1, d2, p, t, p21, t22, Infop31, Infop32 , usInfo , create, P41,
            P42, P51, P52, P53, P61, P62, P71, P73, P82, P111, P112, best_name, best_name2,
            best_name3, best_name4, best_name5, best_name6, best_name7, best_name8, best_name9, best_name10,
            best_name_month, best_name2_month, best_name3_month, best_name4_month, best_name5_month,
            best_name6_month, best_name7_month, best_name8_month, best_name9_month, best_name10_month};

            string[] viewdataName = { "day1" , "day2", "pcycle" , "tcycle", "p21" , "t22", "p31", "p32",
            "UserInfo", "Created", "p41","p42","p51", "p52", "p53", "p61", "p62", "p71", "p73", "p82",
            "p111", "p112", "best_name_cur", "best_name_cur2", "best_name_cur3", "best_name_cur4", "best_name_cur5",
            "best_name_cur6", "best_name_cur7", "best_name_cur8", "best_name_cur9", "best_name_cur10",
            "best_name_month", "best_name_month2", "best_name_month3", "best_name_month4", "best_name_month5",
            "best_name_month6", "best_name_month7", "best_name_month8", "best_name_month9", "best_name_month10"};
            int j = 0;
            for (int i = 0; i < param_value.Length; i++)
            {
                ViewData[viewdataName[j]] = param_value[i];
                j++;
            }

            return Page();
        }

        private async Task<string> downloadData()
        {
            HttpClient client = new HttpClient();
            string call = "https://www.jsonkeeper.com/b/DCLC";
            string json = await client.GetStringAsync(call);
            return json;
        }

        private async Task<string> Day1()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.days_1.ToString();
            return m;
        }
        private async Task<string> Day2()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.days_2.ToString();
            return m;
        }
        private async Task<string> PCycle()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param1_1.ToString();
            return m;
        }
        private async Task<string> TCycle()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param1_2.ToString();
            return m;
        }
        private async Task<string> P2_1()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param2_1.ToString();
            return m;
        }
        private async Task<string> T2_2()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param2_2.ToString();
            return m;
        }
        private async Task<string> Showp31()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param3_1.ToString();
            return m;
        }
        private async Task<string> Showp33()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param3_3.ToString();
            return m;
        }
        private async Task<string> ShowCreated()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.created;
            return m;
        }
        private async Task<string> Showp32()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param3_2.ToString();
            return m;
        }
        private async Task<string> Showp41()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param4_1.ToString();
            return m;
        }
        private async Task<string> Showp42()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param4_2.ToString();
            return m;
        }
        private async Task<string> Showp43()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param4_3.ToString();
            return m;
        }
        private async Task<string> Showp51()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param5_1.ToString();
            return m;
        }
        private async Task<string> Showp52()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param5_2.ToString();
            return m;
        }
        private async Task<string> Showp53()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param5_3.ToString();
            return m;
        }
        private async Task<string> Showp61()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param6_1.ToString();
            return m;
        }
        private async Task<string> Showp62()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param6_2.ToString();
            return m;
        }
        private async Task<string> Showp63()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param6_3.ToString();
            return m;
        }
        private async Task<string> Showp71()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param7_1.ToString();
            return m;
        }
        private async Task<string> Showp72()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param7_2.ToString();
            return m;
        }
        private async Task<string> Showp73()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param7_3.ToString();
            return m;
        }
        private async Task<string> Showp74()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param7_4.ToString();
            return m;
        }
        private async Task<string> Showp75()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param7_5.ToString();
            return m;
        }
        private async Task<string> Showp81()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param8_1.ToString();
            return m;
        }
        private async Task<string> Showp82()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param8_2.ToString();
            return m;
        }
        private async Task<string> Showp83()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param8_3.ToString();
            return m;
        }
        private async Task<string> Showp84()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param8_4.ToString();
            return m;
        }
        private async Task<string> Showp85()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param8_5.ToString();
            return m;
        }
        private async Task<string> Showp111()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param11_1.ToString();
            return m;
        }
        private async Task<string> Showp112()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param11_2.ToString();
            return m;
        }
        private async Task<string> Showp113()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.param11_3.ToString();
            return m;
        }
        private async Task<string> ShowUs1name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[0].name.ToString();
            return m;
        }
        private async Task<string> ShowUs1time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[0].time.ToString();
            return m;
        }
        private async Task<string> ShowUs2name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[1].name.ToString();
            return m;
        }
        private async Task<string> ShowUs2time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[1].time.ToString();
            return m;
        }
        private async Task<string> ShowUs3name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[2].name.ToString();
            return m;
        }
        private async Task<string> ShowUs3time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[2].time.ToString();
            return m;
        }
        private async Task<string> ShowUs4name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[3].name.ToString();
            return m;
        }
        private async Task<string> ShowUs4time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[3].time.ToString();
            return m;
        }
        private async Task<string> ShowUs5name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[4].name.ToString();
            return m;
        }
        private async Task<string> ShowUs5time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[4].time.ToString();
            return m;
        }
        private async Task<string> ShowUs6name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[5].name.ToString();
            return m;
        }
        private async Task<string> ShowUs6time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[5].time.ToString();
            return m;
        }
        private async Task<string> ShowUs7name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[6].name.ToString();
            return m;
        }
        private async Task<string> ShowUs7time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[6].time.ToString();
            return m;
        }
        private async Task<string> ShowUs8name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[7].name.ToString();
            return m;
        }
        private async Task<string> ShowUs8time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[7].time.ToString();
            return m;
        }
        private async Task<string> ShowUs9name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[8].name.ToString();
            return m;
        }
        private async Task<string> ShowUs9time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[8].time.ToString();
            return m;
        }
        private async Task<string> ShowUs10name()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[9].name.ToString();
            return m;
        }
        private async Task<string> ShowUs10time()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_1[9].time.ToString();
            return m;
        }
        private async Task<string> ShowUs1nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[0].name.ToString();
            return m;
        }
        private async Task<string> ShowUs1timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[0].time.ToString();
            return m;
        }
        private async Task<string> ShowUs2nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[1].name.ToString();
            return m;
        }
        private async Task<string> ShowUs2timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[1].time.ToString();
            return m;
        }
        private async Task<string> ShowUs3nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[2].name.ToString();
            return m;
        }
        private async Task<string> ShowUs3timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[2].time.ToString();
            return m;
        }
        private async Task<string> ShowUs4nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[3].name.ToString();
            return m;
        }
        private async Task<string> ShowUs4timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[3].time.ToString();
            return m;
        }
        private async Task<string> ShowUs5nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[4].name.ToString();
            return m;
        }
        private async Task<string> ShowUs5timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[4].time.ToString();
            return m;
        }
        private async Task<string> ShowUs6nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[5].name.ToString();
            return m;
        }
        private async Task<string> ShowUs6timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[5].time.ToString();
            return m;
        }
        private async Task<string> ShowUs7nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[6].name.ToString();
            return m;
        }
        private async Task<string> ShowUs7timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[6].time.ToString();
            return m;
        }
        private async Task<string> ShowUs8nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[7].name.ToString();
            return m;
        }
        private async Task<string> ShowUs8timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[7].time.ToString();
            return m;
        }
        private async Task<string> ShowUs9nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[8].name.ToString();
            return m;
        }
        private async Task<string> ShowUs9timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[8].time.ToString();
            return m;
        }
        private async Task<string> ShowUs10nameBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[9].name.ToString();
            return m;
        }
        private async Task<string> ShowUs10timeBest()
        {
            string json = await downloadData();
            ProductionIndicators cur = JsonConvert.DeserializeObject<ProductionIndicators>(json);
            string m = string.Empty;
            m = cur.result.users_2[9].time.ToString();
            return m;
        }
    }
}