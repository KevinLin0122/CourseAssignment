using System;
using System.Collections.Generic;
using ConsoleApp1.Model;
using System.Xml;
using XMLFunction;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            #region Variable
            XmlDocument doc = new XmlDocument();
            XmlNodeList nodeList;
            XmlNode node;
            XmlAttributeCollection attributeCollection;
            XmlAttribute attribute;
            List<XmlElement> allElement = new List<XmlElement>();
            StockInfo stockInfo = new StockInfo(); 
            List<StockInfo> stockInfoList = new List<StockInfo>();
            List<string> attributeList = new List<string>();
            string value;
            #endregion
            Function.LoadData(doc, @"D:\SoftwareEngineering\Assignment\1005\Stocklnfo.xml");
            allElement = Function.getAllElement(doc);
            for (int i = 0; i < allElement.Count; i++)
            {
                nodeList = Function.getChildnodeList(allElement[i]);
                List<string> valueList = new List<string>();
                for (int index = 0; index < nodeList.Count; index++)
                {
                    node = Function.getChildnode(nodeList, index);
                    value = Function.getNodeValue(node);
                    valueList.Add(value);
                }
                stockInfo = setStockInfo(valueList);
                stockInfoList.Add(stockInfo);
            }
            nodeList = Function.getChildnodeList(allElement[0]);
            for (int i = 0; i < nodeList.Count; i++)
            {
                attributeCollection = Function.getAttributeCollection(nodeList, i);
                attributeList.Add(Function.getAttribute(attributeCollection, 0));
            }
            showStockInfo(attributeList, stockInfoList);
            Console.ReadKey();
            
        }

        static StockInfo setStockInfo(List<string> value)
        {
            StockInfo stock = new StockInfo();
            stock.Date = value[0];
            stock.ID = value[1];
            stock.Name = value[2];
            stock.Close = value[3];
            stock.AdvanceDeclin = value[4];
            stock.Open = value[5];
            stock.Dayhigh = value[6];
            stock.Daylow = value[7];
            stock.TotalStockVolume = value[8];
            stock.TotalDollarCount = value[9];
            stock.TotalCount = value[10];
            stock.LastBuying = value[11];
            stock.LastSelling = value[12];
            stock.PulishStockCount = value[13];
            stock.LimitUpPrice = value[14];
            stock.LimitDownPrice = value[15];
            return stock;
        }
        
        static void showStockInfo(List<string> attributList, List<StockInfo> infoList)
        {
            Console.WriteLine("Total Amount of Data = {0}", infoList.Count);
            for (int i = 0; i < infoList.Count; i++)
            {
                Console.WriteLine("{0}: {1}", attributList[0], infoList[i].Date);
                Console.WriteLine("{0}: {1}", attributList[1], infoList[i].ID);
                Console.WriteLine("{0}: {1}", attributList[2], infoList[i].Name);
                Console.WriteLine("{0}: {1}", attributList[3], infoList[i].Close);
                Console.WriteLine("{0}: {1}", attributList[4], infoList[i].AdvanceDeclin);
                Console.WriteLine("{0}: {1}", attributList[5], infoList[i].Open);
                Console.WriteLine("{0}: {1}", attributList[6], infoList[i].Dayhigh);
                Console.WriteLine("{0}: {1}", attributList[7], infoList[i].Daylow);
                Console.WriteLine("{0}: {1}", attributList[8], infoList[i].TotalStockVolume);
                Console.WriteLine("{0}: {1}", attributList[9], infoList[i].TotalDollarCount);
                Console.WriteLine("{0}: {1}", attributList[10], infoList[i].TotalCount);
                Console.WriteLine("{0}: {1}", attributList[11], infoList[i].LastBuying);
                Console.WriteLine("{0}: {1}", attributList[12], infoList[i].LastSelling);
                Console.WriteLine("{0}: {1}", attributList[13], infoList[i].PulishStockCount);
                Console.WriteLine("{0}: {1}", attributList[14], infoList[i].LimitUpPrice);
                Console.WriteLine("{0}: {1}", attributList[15], infoList[i].LimitDownPrice);
                Console.WriteLine("\n\n");
            }
        }
    }
}