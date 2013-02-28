using System;

namespace YearSummary
{
    /// <summary>
    /// 
    /// </summary>
	public class WatAllDatas
	{
		public int wellID;
		public string Name;

		public int RemainMoney;
		public int RemainAmount;

		public int AllSaleMoney;
		public int AllSaleAmount;

		public int UsedMoney;
		public int UsedAmount;
		
		public string Remark;
		public DateTime BeginDT;
        public DateTime EndDT;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] GetDataArray()
        {
            string[] subItems = new string[] { 
                this.RemainMoney.ToString(), 
                this.RemainAmount.ToString(), 
                this.AllSaleMoney.ToString(),
                this.AllSaleAmount.ToString(), 
                this.UsedMoney.ToString(), 
                this.UsedAmount.ToString(), 
                this.BeginDT.ToString(), 
                this.EndDT.ToString(),
                this.Remark 
            };
            return subItems;
        }
	}
}
