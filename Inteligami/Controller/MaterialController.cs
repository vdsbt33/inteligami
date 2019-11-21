using Inteligami.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inteligami.Controller
{
    public class MaterialController
    {
        private static MaterialController _instance;
        public static MaterialController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MaterialController();
                return _instance;
            }
        }

        private MaterialController()
        {
            AvaibleStock = new List<Material>()
            {
                new Material() { Name = "Queijo", Amount = 0, Price = .8, ConsumptionRate = 1 },
                new Material() { Name = "Apresuntado", Amount = 0, Price = .8, ConsumptionRate = 1 },
                new Material() { Name = "Tomate", Amount = 0, Price = 1, ConsumptionRate = 0.5 },
                new Material() { Name = "Açucar", Amount = 0, Price = 7, ConsumptionRate = 0.08 }
            };
        }

        public List<Material> AvaibleStock;

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Amount of money spent in order to use the material. If 0, no material was bought</returns>
        public double SpendMaterial(Material material, double amount)
        {
            double result = 0;
            if (amount > AvaibleStock.Where(p => p == material).FirstOrDefault().Amount)
            {
                result = material.Price;
                AvaibleStock.Where(p => p == material).FirstOrDefault().Amount++;
            }
            AvaibleStock.Where(p => p == material).FirstOrDefault().Amount -= amount;

            return result;
        }

        /// <summary>
        /// Resets the amount of all materials to 0
        /// </summary>
        /// <returns></returns>
        private void ResetAmount()
        {
            foreach (Material material in AvaibleStock)
            {
                material.Amount = 0;
            }
        }

        /// <summary>
        /// Calculates for X amount of expenses
        /// </summary>
        public List<ProductExpenses> GetMaths(int iterationsNumber)
        {
            ResetAmount();
            List<ProductExpenses> result = new List<ProductExpenses>();

            for (int i = 0; i < iterationsNumber; i++)
            {
                double totalExpense = 0;
                List<string> materialsBought = new List<string>();
                foreach (Material material in AvaibleStock)
                {
                    double currentExpense = 0;
                    currentExpense += SpendMaterial(material, material.ConsumptionRate);
                    totalExpense += currentExpense;
                    if (currentExpense > 0)
                        materialsBought.Add(material.Name);
                }
                result.Add(new ProductExpenses() { materialList = string.Format("{0}", string.Join(", ", materialsBought)), totalValue = totalExpense });
            }

            return result;
        }
    }
}
