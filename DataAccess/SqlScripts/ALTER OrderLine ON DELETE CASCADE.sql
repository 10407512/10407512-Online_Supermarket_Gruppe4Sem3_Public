ALTER TABLE orderLine
ADD CONSTRAINT fk_order_orderNo 
FOREIGN KEY (order_orderNo)
REFERENCES [Order] (orderNo)
ON DELETE CASCADE;