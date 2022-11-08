using FluentAssertions;
using TestApp.BuildingBlocks.Domain;
using TestApp.Module.Rfc.Domain.Product;

namespace TestApp.Module.Rfc.UnitTests
{
    public class ProductTests
    {
        public static IEnumerable<object[]> ConstructorTestData()
        {
            yield return new object[] { "", "" };
            yield return new object[] { "", "version" };
            yield return new object[] { "title", "" };
        }

        private static Product CreateProduct()
        {
            return Product.Create("title", "version");
        }


        [Theory]
        [MemberData(nameof(ConstructorTestData))]
        public void New_product_requires_title_and_version(string title, string version)
        {
            Action createProduct = () => Product.Create(title, version);

            createProduct.Should().Throw<BusinessRuleValidationException>();
        }

        [Fact]
        public void New_product_can_be_created_with_title_and_version()
        {
            Action createProduct = () => Product.Create("title", "version");

            createProduct.Should().NotThrow();
        }

        [Fact]
        public void New_product_can_be_started()
        {
            var product = CreateProduct();

            var startProduct = () => product.Start();

            startProduct.Should().NotThrow();
        }

        [Fact]
        public void New_product_cannot_be_deprecated()
        {
            var product = CreateProduct();

            var deprecatedProduct = () => product.Deprecate();

            deprecatedProduct.Should().Throw<BusinessRuleValidationException>();
        }

        [Fact]
        public void ApprovedForUse_product_can_be_deprecated()
        {
            var product = CreateProduct();
            product.ApproveForUse();

            var deprecatedProduct = () => product.Deprecate();

            deprecatedProduct.Should().NotThrow();
        }

        [Fact]
        public void ApprovedForUse_product_can_be_draft()
        {
            var product = CreateProduct();
            product.ApproveForUse();

            var draftedProduct = () => product.Draft();

            draftedProduct.Should().NotThrow();
        }

        [Fact]
        public void ApprovedForUse_product_cannot_be_approvedForUse_again()
        {
            var product = CreateProduct();
            product.ApproveForUse();

            var approvedForUseProduct = () => product.ApproveForUse();

            approvedForUseProduct.Should().Throw<BusinessRuleValidationException>();
        }


        [Fact]
        public void Deprecated_product_cannot_be_draft()
        {
            var product = CreateProduct();
            product.ApproveForUse();
            product.Deprecate();

            var draftedProduct = () => product.Draft();

            draftedProduct.Should().Throw<BusinessRuleValidationException>();
        }

        [Fact]
        public void Deprecated_product_cannot_be_deprecated_again()
        {
            var product = CreateProduct();
            product.ApproveForUse();
            product.Deprecate();

            var deprecatedProduct = () => product.Deprecate();

            deprecatedProduct.Should().Throw<BusinessRuleValidationException>();
        }

        [Fact]
        public void Deprecated_product_cannot_be_approvedForUse()
        {
            var product = CreateProduct();
            product.ApproveForUse();
            product.Deprecate();

            var approvedForUseProduct = () => product.ApproveForUse();

            approvedForUseProduct.Should().Throw<BusinessRuleValidationException>();
        }

    }
}
