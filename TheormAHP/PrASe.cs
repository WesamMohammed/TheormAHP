using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static TheormAHP.AHPPAS;

namespace TheormAHP
{
   public class PrimaryAndSecondaryAlgorithm
    {
        
        private List<List<double>> pairwiseComparisons = new List<List<double>>();
        public List<double> weights { get; private set; }

        public static void PrimaryAndSecondary()
        {
            PrimaryAndSecondaryAlgorithm primaryAndSecondaryAlgorithm = new PrimaryAndSecondaryAlgorithm();
            
            var weid1 = primaryAndSecondaryAlgorithm.weights[0];
            var weid2 = primaryAndSecondaryAlgorithm.weights[1];
            //weightsStorage.PrimaryAndSecondaryWeights = primaryAndSecondaryAlgorithm.weights;
        }

        

        public PrimaryAndSecondaryAlgorithm()
        {
            // TODO: Complete member initialization
        }

        public void PerformAHP(int option,int _option1, int compValue, out double weid1, out double weid2)
        {
            weights = new List<double>();
            int numberOfCriteria = 2;
            

            List<double> finalWeights = new List<double>();
            if (option == 1)
            {
                // Manual entry of final weights
                for (int k = 0; k < numberOfCriteria; k++)
                {
                    
                    double weight = double.Parse(Console.ReadLine());
                    weights.Add(weight);
                }
            }
            else if (option == 2)
           {

                for (int i = 0; i < numberOfCriteria; i++)
                {
                    List<double> comparisonRow = new List<double>();
                    for (int j = 0; j < numberOfCriteria; j++)
                    {
                        if (i == j)
                        {
                            comparisonRow.Add(1);
                        }
                        else
                        {
                            
                            int option1=_option1;
                            
                            if (option1 == 1)
                            {
                              if (i > j)
                               {
                                   if (pairwiseComparisons[j][i] != 0)
                                    {
                                        comparisonRow.Add(1 / pairwiseComparisons[j][i]);
                                   }
                                   else
                                   {
                                       double comparisonValue = compValue;
                                        comparisonRow.Add(1 / comparisonValue);
                                    }
                                }
                               else
                               {
                                 
                                   double comparisonValue = compValue;
                                    comparisonRow.Add(comparisonValue);
                                }
                            }
                     if (option1 == 2)
                            {
                                if (i > j)
                                {
                                    if (pairwiseComparisons[j][i] != 0)
                                    {
                                        comparisonRow.Add(1 / pairwiseComparisons[j][i]);
                                    }
                                    else
                                    {
                                        double comparisonValue = compValue;
                                       
                                        comparisonRow.Add(comparisonValue);
                                    }
                                }
                                else
                                {
                                    
                                    double comparisonValue = compValue;
                                    comparisonRow.Add(1/comparisonValue);
                                }
                                
                            }
                        }
                    }
                    pairwiseComparisons.Add(comparisonRow); 
                }

                int n = numberOfCriteria;
                for (int m = 0; m < n; m++)
                {
                    double product = 1;
                    for (int j = 0; j < n; j++)
                    {
                        product *= pairwiseComparisons[m][j];
                    }
                    double geometricMean = Math.Pow(product, 1.0 / n);
                    weights.Add(geometricMean);
                }

                double sum = weights.Sum();

                for (int l = 0; l < n; l++)
                {
                    weights[l] /= sum;
                }
            }
            weid1 = weights[0];
            weid2 = weights[1];
        }
        public List<double> PerformAHP(Dictionary<int, Contents> map)
        {
            weights = new List<double>();
            int numberOfCriteria = 16;


            List<double> finalWeights = new List<double>();
            /*  if (option == 1)
              {
                  // Manual entry of final weights
                  for (int k = 0; k < numberOfCriteria; k++)
                  {

                      double weight = double.Parse(Console.ReadLine());
                      weights.Add(weight);
                  }
              }
              else if (option == 2)
              {

                  for (int i = 0; i < numberOfCriteria; i++)
                  {
                      List<double> comparisonRow = new List<double>();
                      for (int j = 0; j < numberOfCriteria; j++)
                      {
                          if (i == j)
                          {
                              comparisonRow.Add(1);
                          }
                          else
                          {

                              int option1 = _option1;

                              if (option1 == 1)
                              {
                                  if (i > j)
                                  {
                                      if (pairwiseComparisons[j][i] != 0)
                                      {
                                          comparisonRow.Add(1 / pairwiseComparisons[j][i]);
                                      }
                                      else
                                      {
                                          double comparisonValue = compValue;
                                          comparisonRow.Add(1 / comparisonValue);
                                      }
                                  }
                                  else
                                  {

                                      double comparisonValue = compValue;
                                      comparisonRow.Add(comparisonValue);
                                  }
                              }
                              if (option1 == 2)
                              {
                                  if (i > j)
                                  {
                                      if (pairwiseComparisons[j][i] != 0)
                                      {
                                          comparisonRow.Add(1 / pairwiseComparisons[j][i]);
                                      }
                                      else
                                      {
                                          double comparisonValue = compValue;

                                          comparisonRow.Add(comparisonValue);
                                      }
                                  }
                                  else
                                  {

                                      double comparisonValue = compValue;
                                      comparisonRow.Add(1 / comparisonValue);
                                  }

                              }
                          }
                      }
                      pairwiseComparisons.Add(comparisonRow);
                  }

                  int n = numberOfCriteria;
                  for (int m = 0; m < n; m++)
                  {
                      double product = 1;
                      for (int j = 0; j < n; j++)
                      {
                          product *= pairwiseComparisons[m][j];
                      }
                      double geometricMean = Math.Pow(product, 1.0 / n);
                      weights.Add(geometricMean);
                  }

                  double sum = weights.Sum();

                  for (int l = 0; l < n; l++)
                  {
                      weights[l] /= sum;
                  }
              }
              weid1 = weights[0];
              weid2 = weights[1];*/
            return weights;
        }



        private double GetValidComparisonValue(int compValue)
        {
            int comparisonValue = compValue;
            
            return comparisonValue;
        }
        public static void SaveWeights(List<double> weights)
        {
            File.WriteAllLines("weights.txt", weights.Select(w => w.ToString()));
        }

        public static List<double> LoadWeights()
        {
            List<double> weights = new List<double>();
            if (File.Exists("weights.txt"))
            {
                string[] lines = File.ReadAllLines("weights.txt");

                foreach (string line in lines)
                {
                    double weight;
                    if (double.TryParse(line, out weight))
                    {
                        weights.Add(weight);
                    }
                }
            }
            return weights;
        }

        
    }
}
public class WeightsStorage
{
    public List<double> PrimaryAndSecondaryWeights { get; set; }

    public WeightsStorage()
    {
        PrimaryAndSecondaryWeights = new List<double>();
    }
}


