using SuperParser.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace SuperParser.DAL.Interfaces
{
    public interface IPagesEnumerable<T> : IEnumerable<T>
    {
        void SetSettings(IParserSettings settings);
        void SetHtmlLoader(ILoader<T> loader);
    }
}
