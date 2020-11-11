CREATE TABLE tbl_admin (
    admin_id int NOT NULL,
    admin_Name varchar(255),
    admin_emailid varchar(255),
    PRIMARY KEY (admin_id)
);
CREATE TABLE tbl_lookup_userinfo (
    Userid int IDENTITY (1,1) NOT NULL,
    LastName varchar(255),
    FirstName varchar(255),
    Age int,
    Addressid int,
    Emailid varchar(255),
    Phonenumber varchar,
    PRIMARY KEY (Userid)
);
CREATE TABLE tbl_lookup_address (
    Addressid int IDENTITY (1,1) NOT NULL,
    door_no varchar(255),
    addressline_1 varchar(255),
    addressline_2 varchar(255),
    city varchar(255),
    province varchar(255),
    pincode varchar(255),
    country varchar(255),
    PRIMARY KEY (Addressid)
);
CREATE TABLE tbl_lookup_user_role (
    Userid int NOT NULL,
    memrbership_flag varchar(10),
    FOREIGN KEY (Userid) REFERENCES tbl_lookup_userinfo(Userid)
);
CREATE TABLE tbl_lookup_product (
    product_id int NOT NULL,
    product_Name varchar(255),
    category_id int,
    product_price float,
    PRIMARY KEY (product_id),
    FOREIGN KEY (category_id) REFERENCES tbl_lookup_category(category_id)
);
CREATE TABLE tbl_lookup_category (
    category_id int NOT NULL,
    category_Name varchar(255),
    PRIMARY KEY (category_id)
);
CREATE TABLE tbl_lookup_subcategory (
    subcategory_id int NOT NULL,
    subcategory_Name varchar(255),
    category_id int,
    PRIMARY KEY (subcategory_id),
    FOREIGN KEY (category_id) REFERENCES tbl_lookup_category(category_id)
);
CREATE TABLE tbl_lookup_store (
    store_id int IDENTITY (1,1) NOT NULL,
    store_name varchar(255),
    door_no varchar(255),
    addressline_1 varchar(255),
    addressline_2 varchar(255),
    city varchar(255),
    province varchar(255),
    pincode varchar(255),
    country varchar(255),
    PRIMARY KEY (store_id)
);
CREATE TABLE tbl_temporary_order (
    Userid int,
    store_id int,
    product_id int
);
CREATE TABLE tbl_slot_delivery (
    slot_id int,
    orderid int,
    slot_start_time datetime,
    slot_end_time datetime,
    PRIMARY KEY (slot_id),
    FOREIGN KEY (orderid) REFERENCES tbl_order(orderid)
);
CREATE TABLE tbl_order (
    orderid int IDENTITY (1,1) NOT NULL,
    Userid int,
    no_of_items int,
    store_id int,
    Addressid int,
    order_date datetime,
    order_status varchar(255),
    delivery_date datetime,
    order_amount float,
    PRIMARY KEY (orderid),
    FOREIGN KEY (Userid) REFERENCES tbl_lookup_userinfo(Userid),
    FOREIGN KEY (Addressid) REFERENCES tbl_lookup_address(Addressid),
    FOREIGN KEY (store_id) REFERENCES tbl_lookup_store(store_id)
);
CREATE TABLE tbl_order_line (
    order_line_id int NOT NULL,
    orderid int,
    product_id int,
    store_id int,
    line_amount float,
    PRIMARY KEY (order_line_id),
    FOREIGN KEY (product_id) REFERENCES tbl_lookup_product(product_id),
    FOREIGN KEY (orderid) REFERENCES tbl_order(orderid),
    FOREIGN KEY (store_id) REFERENCES tbl_lookup_store(store_id)
);
CREATE TABLE tbl_legacy_order (
    orderid int IDENTITY (1,1) NOT NULL,
    Userid int,
    no_of_items int,
    store_id int,
    Addressid int,
    order_date datetime,
    order_status varchar(255),
    delivery_date datetime,
    PRIMARY KEY (orderid)
);

use iwin;