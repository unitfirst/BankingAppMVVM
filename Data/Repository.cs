using BankingAppMVVM.MVVM.View;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppMVVM.Data
{
    internal class Repository
    {
        private readonly string _path;
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Return item by index or null, if item doesnt exist
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// 
        public Account this[int index]
        {
            get { return this.Accounts.ElementAt(index); }
        }

        /// <summary>
        /// Return item by FirstName or null, if item doesnt exist
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public Account this[string Name]
        {
            get
            {
                Account n = null;
                foreach (var e in Accounts)
                {
                    if (e.FirstName == Name)
                    {
                        n = e;
                        break;
                    }
                }
                return n;
            }
        }

        public Repository(string path)
        {
            _path = path;
        }

        public ObservableCollection<Account> Load()
        {
            if (!File.Exists(_path))
            {
                File.CreateText(_path).Dispose();
                return new ObservableCollection<Account>();
            }

            using (var reader = File.OpenText(_path))
            {
                var result = JsonConvert.DeserializeObject<ObservableCollection<Account>>(reader.ReadToEnd());

                return result;
            }
        }
        public void Save(object accounts)
        {
            using (StreamWriter writer = File.CreateText(_path))
            {
                if (accounts != null)
                {
                    writer.Write(JsonConvert.SerializeObject(accounts));
                }
            }
        }

        public void DeleteFile(string path)
        {
            File.Delete(_path);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var e in this.Accounts)
            {
                yield return e;
            }
        }
    }
}
