using FinancialControlSystem.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FinancialControlSystem.Logic
{
    public class DataStorage
    {
        private Dictionary<int, TransactionCategoryModel> _transactionsCategories;
        private Dictionary< int, TransactionModel> _transactionsModels;
        private Dictionary<int, ClientFinancialModel> _clientFinancialModels;
        private int _transactionCategoriesLastId;
        public DataStorage() 
        {
            _transactionsCategories = new Dictionary<int, TransactionCategoryModel>();
            _transactionsModels = new Dictionary<int, TransactionModel>();
            _clientFinancialModels = new Dictionary<int, ClientFinancialModel>();
            _transactionCategoriesLastId = 1;
        }
        public void AddCategory (TransactionCategoryModel category)
        {
            _transactionsCategories.Add(_transactionCategoriesLastId, category);
            _transactionCategoriesLastId++;
        }
        public void DeleteCategoryById (int Id) 
        {
            _transactionsCategories.Remove(Id);
        }
       public TransactionCategoryModel GetCategoryModelById (int Id)
        {
            return _transactionsCategories[Id];
        }
        public List<TransactionCategoryModel>GetCategoryModels ()
        {
            return _transactionsCategories.Values.ToList();
        }

    }

}
