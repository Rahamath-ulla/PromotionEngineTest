using System;

namespace PromotionEngine
{
    public class Scenario
    {
        public static int ScenarioA(int QTY, int OfferQTY, int Offer, int Price)
        {
            int BalanceQTY, Sum;
            BalanceQTY = QTY - OfferQTY;
            Sum = Offer + BalanceQTY * Price;
            return Sum;
        }

        public static int ScenarioB(int QTY, int OfferQTY, int Offer, int Price, int Sum)
        {
            int BalanceQTY;
            BalanceQTY = QTY;
            decimal loop = QTY / 2;
            for (int i = 0; i < Math.Round(loop); i++)
            {
                BalanceQTY = BalanceQTY - OfferQTY;
                Sum += Offer;
            }
            Sum = Sum + Price;
            return Sum;
        }
    }
}