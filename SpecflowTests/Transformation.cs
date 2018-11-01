using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTests
{
    [Binding]
    public class Transformation
    {
        [StepArgumentTransformation]
        public List<string> ToPhoneVersionsList(string phoneVersions)
        {
            List<string> versions = phoneVersions.Split(',').Select(s => s.Trim()).ToList();
            return versions;
        }

    }
}
