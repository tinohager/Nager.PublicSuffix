﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.PublicSuffix.Extensions;
using System.Collections.Generic;

namespace Nager.PublicSuffix.UnitTest
{
    [TestClass]
    public class DomainParserTestWithInitializedStructure : DomainParserTest
    {
        protected override IDomainParser GetDomainParser(List<TldRule> rules)
        {
            var structure = new DomainDataStructure("*", new TldRule("*"));
            structure.AddRules(rules);
            return new DomainParser(structure);
        }
    }
}
