using System;
using System.Collections.Generic;

namespace _10_Collections {
    internal class Portfolio {
        private List<IAsset> stocks = new List<IAsset>();
        public Portfolio() {
        }

        public Portfolio(List<IAsset> stocks) {
            this.stocks = stocks;
        }

        internal double GetTotalValue() {
            double res = 0;
            for (int i = 0; i < stocks.Count; i++) {
                res += stocks[i].GetValue();
            }
            return res;
        }
        public static double TotalValue(IAsset[] stocks) {
            double res = 0;
            for (int i = 0; i < stocks.Length; i++) {
                res += stocks[i].GetValue();
            }
            return res;
        }

        internal IList<IAsset> GetAssets() {
            throw new NotImplementedException();
        }

        internal void AddAsset(IAsset asset) {
            stocks.Add(asset);
        }

        internal Stock GetAssetByName(string v) {
            throw new NotImplementedException();
        }

        internal IList<IAsset> GetAssetsSortedByName() {
            throw new NotImplementedException();
        }

        internal IList<IAsset> GetAssetsSortedByValue() {
            throw new NotImplementedException();
        }
    }
}