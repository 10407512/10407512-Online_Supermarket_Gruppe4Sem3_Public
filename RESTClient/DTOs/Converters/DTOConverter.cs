using DataAccess.Model;

namespace RESTClient.DTOs.Converters
{
    public static class DTOConverter
    {

        #region Order conversion methods
        public static OrderDTO ToDto(this Order orderToConvert)
        {
            var orderDto = new OrderDTO();
            orderToConvert.CopyPropertiesTo(orderDto);
            orderDto.OrderLines = orderToConvert.OrderLines.ToDtos().ToList();
            if (orderToConvert.Person != null)
            {
                orderDto.Person = orderToConvert.Person.ToDto();
            }
            return orderDto;
        }

        public static Order FromDto(this OrderDTO orderDtoToConvert)
        {
            var order = new Order();
            orderDtoToConvert.CopyPropertiesTo(order);
            order.OrderLines = orderDtoToConvert.OrderLines.FromDtos().ToList();
            if(orderDtoToConvert.Person != null)
            {
                order.Person = orderDtoToConvert.Person.FromDto();
            }
            return order;
        }

        public static IEnumerable<OrderDTO> ToDtos(this IEnumerable<Order> ordersToConvert)
        {
            foreach (var order in ordersToConvert)
            {
                yield return order.ToDto();
            }
        }

        public static IEnumerable<Order> FromDtos(this IEnumerable<OrderDTO> orderDtosToConvert)
        {
            foreach (var orderDto in orderDtosToConvert)
            {
                yield return orderDto.FromDto();
            }
        }
        #endregion


        #region Person conversion methods
        public static PersonDTO ToDto(this Person personToConvert)
        {
            var personDto = new PersonDTO();
            personToConvert.CopyPropertiesTo(personDto);
            return personDto;
        }

        public static Person FromDto(this PersonDTO personDtoToConvert)
        {
            var person = new Person();
            personDtoToConvert.CopyPropertiesTo(person);
            return person;
        }

        public static IEnumerable<PersonDTO> ToDtos(this IEnumerable<Person> personsToConvert)
        {
            foreach (var person in personsToConvert)
            {
                yield return person.ToDto();
            }
        }

        public static IEnumerable<Person> FromDtos(this IEnumerable<PersonDTO> personDtosToConvert)
        {
            foreach (var personDto in personDtosToConvert)
            {
                yield return personDto.FromDto();
            }
        }
        #endregion

        #region OrderLine conversion methods
        public static IEnumerable<OrderLineDTO> ToDtos(this IEnumerable<OrderLine> ordersToConvert)
        {
            foreach (var orderline in ordersToConvert)
            {
                yield return orderline.ToDto();
            }
        }

        public static OrderLineDTO ToDto(this OrderLine orderLineToConvert)
        {
            var orderLineDTO = new OrderLineDTO();
            orderLineToConvert.CopyPropertiesTo(orderLineDTO);
            orderLineDTO.Product = orderLineToConvert.Product.ToDto();
            return orderLineDTO;
        }

        public static IEnumerable<OrderLine> FromDtos(this IEnumerable<OrderLineDTO> ordersToConvert)
        {
            foreach (var orderline in ordersToConvert)
            {
                yield return orderline.FromDto();
            }
        }

        public static OrderLine FromDto(this OrderLineDTO orderLineToConvert)
        {
            var orderLine = new OrderLine();
            orderLineToConvert.CopyPropertiesTo(orderLine);
            orderLine.Product = orderLineToConvert.Product.FromDto();
            return orderLine;
        }
        #endregion

        #region Product conversion methods
        public static ProductDTO ToDto(this Product productToConvert)
        {
            var productDto = new ProductDTO();
            productToConvert.CopyPropertiesTo(productDto);
            return productDto;
        }

        public static Product FromDto(this ProductDTO productDtoToConvert)
        {
            var product = new Product();
            productDtoToConvert.CopyPropertiesTo(product);
            return product;
        }

        public static IEnumerable<ProductDTO> ToDtos(this IEnumerable<Product> productsToConvert)
        {
            foreach (var product in productsToConvert)
            {
                yield return product.ToDto();
            }
        }

        public static IEnumerable<Product> FromDtos(this IEnumerable<ProductDTO> productDtosToConvert)
        {
            foreach (var productDto in productDtosToConvert)
            {
                yield return productDto.FromDto();
            }
        }
        #endregion

    }
}
