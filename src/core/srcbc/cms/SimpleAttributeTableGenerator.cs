using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections;

namespace Org.BouncyCastle.Cms
{
    /**
	 * Basic generator that just returns a preconstructed attribute table
	 */
    public class SimpleAttributeTableGenerator
		: CmsAttributeTableGenerator
	{
		private readonly AttributeTable attributes;

		public SimpleAttributeTableGenerator(
			AttributeTable attributes)
		{
			this.attributes = attributes;
		}

		public virtual AttributeTable GetAttributes(
			IDictionary parameters)
		{
			return attributes;
		}
	}
}
