using System;
using PersonRepository.CSV;
using PersonRepository.Interface;
using PersonRepository.Service;
using PersonRepository.SQL;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonReader GetRepository(string repositoryType)
        {
            IPersonReader repository = null;

            switch (repositoryType)
            {
                case "Service":
                    repository = new ServiceRepository();
                    break;
                case "CSV": 
                    repository = new CSVRepository();
                    break;
                case "SQL": 
                    repository = new SQLRepository();
                    break;
                default:
                    throw new ArgumentNullException("Invalid repository");
            }

            return repository;
        }
    }
}
