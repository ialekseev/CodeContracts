using System;
using NUnit.Framework;

// ReSharper disable InconsistentNaming
namespace CodeContracts.Specs
{
    public class RequiresSpecs
    {
        //todo: cover other methods
        
        [TestFixture]
        public class when_requires_that_good_object_is_not_null
        {
            [Test]            
            public void should_not_throw()
            {
                Requires.NotNull("test", "param");                  
            }
        }

        [TestFixture]
        public class when_requires_that_null_object_is_not_null
        {
            [Test]
            [ExpectedException(typeof(ArgumentNullException))]
            public void should_throw()
            {
                Requires.NotNull<string>(null, "param");
            }
        }

        [TestFixture]
        public class when_requires_that_good_string_is_not_null_or_empty
        {
            [Test]
            public void should_not_throw()
            {
                Requires.NotNullOrEmpty("test", "param");
            }
        }
        
        [TestFixture]
        public class when_requires_that_null_or_empty_string_is_not_null_or_empty
        {
            [TestCase(null, typeof(ArgumentNullException))]
            [TestCase("",typeof(ArgumentException))]            
            public void should_throw(string str, Type targetException)
            {
                Assert.Throws(targetException, () => Requires.NotNullOrEmpty(str, "param"));
            }
        }

        [TestFixture]
        public class when_requires_that_null_string_length_is_greater_than
        {
            [Test]
            [ExpectedException(typeof(ArgumentNullException))]
            public void should_throw()
            {
                Requires.LengthGreaterThan(null, 3, "param");
            }
        }
        
        [TestFixture]
        public class when_requires_that_good_string_length_is_greater_than
        {
            [Test]
            public void should_not_throw()
            {
                Requires.LengthGreaterThan("test", 3, "param");
            }
        }

        [TestFixture]
        public class when_requires_that_short_string_length_is_greater_than
        {
            [Test]
            [ExpectedException(typeof(ArgumentException))]
            public void should_throw()
            {
                Requires.LengthGreaterThan("test", 5, "param");
            }
        }

        [TestFixture]
        public class when_requires_that_null_string_length_is_greater_or_equal_than
        {
            [Test]
            [ExpectedException(typeof(ArgumentNullException))]
            public void should_throw()
            {
                Requires.LengthGreaterOrEqual(null, 3, "param");
            }
        }

        [TestFixture]
        public class when_requires_that_good_string_length_is_greater_or_equal_than
        {
            [Test]
            public void should_not_throw()
            {
                Requires.LengthGreaterOrEqual("test", 4, "param");
            }
        }

        [TestFixture]
        public class when_requires_that_short_string_length_is_greater_or_equal_than
        {
            [Test]
            [ExpectedException(typeof(ArgumentException))]
            public void should_throw()
            {
                Requires.LengthGreaterOrEqual("test", 5, "param");
            }
        }        
    }
}

// ReSharper restore InconsistentNaming