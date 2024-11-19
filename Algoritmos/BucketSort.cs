﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class BucketSort : Form
    {
        Random random;
        int[] numbers;

        public BucketSort()
        {
            InitializeComponent();
            random = new Random();
            numbers = new int[10];

            // Configuración del ListView lstvOrder
            lstvOrder.View = View.Details;
            for (int i = 0; i <= 4; i++)
            {
                lstvOrder.Columns.Add("" + i, 60);
            }

            // Configuración del ListView lstvBucket
            lstvBucket.View = View.Details;
            lstvBucket.Columns.Add("Bucket", 80);
            lstvBucket.Columns.Add("Range", 80);
            lstvBucket.Columns.Add("Bucket numbers", 150);
        }

        private void btnBucketSort_Click(object sender, EventArgs e)
        {
            // Asignar números aleatorios al arreglo
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            // Mezclar el arreglo de números con la clase ArrayShuffler
            ArrayShuffler.Shuffle(numbers);

            // Mostrar los números desordenados en el TextBox
            txtOrder.Text = string.Join(" , ", numbers);

            // Llamar al método de ordenamiento por Bucket Sort
            BS();
        }

        public void BS()
        {
            int bucketCount = 5;
            int bucketSize = 5;
            int[][] buckets = new int[bucketCount][];

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new int[bucketSize];
            }

            // Distribuir números en los buckets
            lstvBucket.Items.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                int bucketIndex = (numbers[i] - 1) / (100 / bucketCount);
                for (int j = 0; j < bucketSize; j++)
                {
                    if (buckets[bucketIndex][j] == 0)
                    {
                        buckets[bucketIndex][j] = numbers[i];
                        break;
                    }
                }
            }

            // Mostrar los buckets en lstvBucket
            for (int i = 0; i < bucketCount; i++)
            {
                string range = (i * (100 / bucketCount) + 1) + " - " + ((i + 1) * (100 / bucketCount));
                string bucketNumbers = string.Join(", ", buckets[i].Where(x => x != 0));
                ListViewItem bucketItem = new ListViewItem((i + 1).ToString());
                bucketItem.SubItems.Add(range);
                bucketItem.SubItems.Add(bucketNumbers);
                lstvBucket.Items.Add(bucketItem);
            }

            // Ordenar cada bucket y mostrar los pasos
            lstvOrder.Items.Clear();
            for (int i = 0; i < bucketCount; i++)
            {
                // Mostrar el estado original del bucket
                AddOriginalBucketState(buckets[i]);

                for (int j = 1; j < bucketSize; j++)
                {
                    int current = buckets[i][j];
                    if (current == 0)
                    {
                        break;
                    }

                    int k = j - 1;
                    while (k >= 0 && buckets[i][k] > current)
                    {
                        // Mover el número hacia adelante
                        buckets[i][k + 1] = buckets[i][k];

                        // Mostrar el estado actual del bucket
                        AddStepToOrder(buckets[i]);
                        k--;
                    }
                    buckets[i][k + 1] = current;

                    // Mostrar el estado después de insertar
                    AddStepToOrder(buckets[i]);
                }
            }

            // Copiar elementos de los buckets al arreglo principal
            int index = 0;
            for (int i = 0; i < bucketCount; i++)
            {
                for (int j = 0; j < bucketSize; j++)
                {
                    if (buckets[i][j] != 0)
                    {
                        numbers[index++] = buckets[i][j];
                    }
                }
            }

            // Mostrar el arreglo final ordenado
            txtOrder.AppendText("\nFinal order: " + string.Join(", ", numbers));
        }

        private void AddOriginalBucketState(int[] bucket)
        {
            // Crear un ListViewItem para mostrar el estado original del bucket
            ListViewItem originalItem = new ListViewItem("Original");

            for (int i = 0; i < bucket.Length; i++)
            {
                string value = bucket[i] == 0 ? "" : bucket[i].ToString();
                if (i == 0)
                {
                    originalItem.Text = value;
                }
                else
                {
                    originalItem.SubItems.Add(value);
                }
            }

            lstvOrder.Items.Add(originalItem);
        }

        private void AddStepToOrder(int[] bucket)
        {
            // Crear un ListViewItem para mostrar el estado actual
            ListViewItem stepItem = new ListViewItem();

            for (int i = 0; i < bucket.Length; i++)
            {
                string value = bucket[i] == 0 ? "" : bucket[i].ToString();
                if (i == 0)
                {
                    stepItem.Text = value;
                }
                else
                {
                    stepItem.SubItems.Add(value);
                }
            }

            lstvOrder.Items.Add(stepItem);
        }

        private void btnBucketSortClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
