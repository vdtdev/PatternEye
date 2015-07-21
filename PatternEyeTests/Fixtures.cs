using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using System.Text;
using System.Reflection;

namespace PatternEyeTests
{
    public class Fixtures
    {
        public class Fixture<T>
        {
            private Object[] attributes;
            public Fixture()
            {
                attributes = new Object[0];
            }
            /// <summary>
            /// Attempt to replace fixture attributes
            /// </summary>
            /// <param name="fixtureData">Replacement fixture attributes</param>
            /// <returns>True if successful</returns>
            public bool replace(Object[] fixtureData)
            {
                bool success = true;
                try
                {
                    this.attributes = fixtureData;
                }
                catch (Exception ex)
                {
                    success = false;
                }
                return success;
            }

            /// <summary>
            /// Fixture attributes
            /// </summary>
            public Object[] Attributes
            {
                get { return this.attributes; }
            }

            public T build(T castType)
            {
                T fixture;
                ConstructorInfo[] ci = castType.GetType().GetConstructors();
                Dictionary<ConstructorInfo, ParameterInfo[]> details = new Dictionary<ConstructorInfo, ParameterInfo[]>();
                foreach (ConstructorInfo c in ci)
                {
                    details[c] = c.GetParameters();
                }

                IEnumerable<ConstructorInfo> pq = from detail in details.Keys where details[detail].Length == attributes.Length select detail;
                
                ParameterInfo[] pi = details[pq.ElementAt(0)];
                return (T)pq.ElementAt(0).Invoke(attributes);
                
            }
        }
    }
}
