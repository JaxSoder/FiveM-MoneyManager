using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.UI;
using CitizenFX.Core.Native;
using static CitizenFX.Core.Native.API;

namespace MoneyManagerMain
{
    public class MoneyManagerMain : BaseScript
    {
        public int wallet_money;
        public int bank_money;

        public MoneyManagerMain()
        {
            DisplayMoneyText();
        }

        private async void DisplayMoneyText()
        {
            while (true)
            {
                DrawMoneyText("~g~$~w~" + wallet_money);
                await Delay(5);
            }
        }

        public void AddMoneyToWallet(int money_to_add)
        {
            Screen.ShowNotification("Given " + "~g~$" + money_to_add + "~w~");
            wallet_money = wallet_money + money_to_add;
        }

        public void TakeMoneyFromWallet(int money_to_take)
        {
            Screen.ShowNotification("Taken " + "~g~$" + money_to_take + "~w~");
            wallet_money = wallet_money + money_to_take;
        }

        public void AddMoneyToBank(int money_to_add)
        {

        }

        public void TakeMoneyFromBank(int money_to_take)
        {

        }

        private static void DrawMoneyText(string text)
        {
            DrawMoneyTextHandler(text, 23, false, 0.93f, 0.05f, 0.8f, 255, 255, 255, 255);
        }

        private static void DrawMoneyTextHandler(string text, int font, bool center, float x, float y, float scale, int r, int g, int b, int a)
        {
            API.SetTextFont(font);
            API.SetTextProportional(false);
            API.SetTextScale(scale, scale);
            API.SetTextColour(r, g, b, a);
            API.SetTextDropShadow();
            API.SetTextEdge(1, 0, 0, 0, 255);
            API.SetTextDropShadow();
            API.SetTextOutline();
            API.SetTextCentre(true);
            API.SetTextEntry("STRING");
            API.AddTextComponentString(text);
            API.DrawText(x, y);
        }
    }
}
