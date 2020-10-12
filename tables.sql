/* Creating tables*/

CREATE TABLE Address(
    address_id INT NOT NULL AUTO_INCREMENT,
    unit_number VARCHAR(50) NOT NULL,
    apartment_number VARCHAR(50) NOT NULL,
    PRIMARY KEY (address_id)
);

CREATE TABLE Vehicle(
    vehicle_id INT NOT NULL AUTO_INCREMENT,
    color VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    make VARCHAR(50) NOT NULL,
    registration_number VARCHAR(50) NOT NULL,
    PRIMARY KEY (vehicle_id)
);

CREATE TABLE Owner(
    owner_id iNT NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(250) NOT NULL,
    last_name VARCHAR(250) NOT NULL,
    phone_number VARCHAR(10) NOT NULL,
    PRIMARY KEY (owner_id)
);

-- CREATE TABLE VehicleOwner(
--     vehicle_id INT,
--     owner_id int,
--     FOREIGN KEY (vehicle_id) REFERENCES Vehicle(vehicle_id),
--     FOREIGN KEY (owner_id) REFERENCES Owner(owner_id)
-- );

-- CREATE TABLE OwnerAddress(
--     owner_id INT,
--     address_id INT,
--     FOREIGN KEY (owner_id) REFERENCES Owner(owner_id),
--     FOREIGN KEY (address_id) REFERENCES Address(address_id)
-- );

/* populating tables */

INSERT INTO Address (unit_number, apartment_number)
    VALUES ("A1", "A315");

INSERT INTO Address (unit_number, apartment_number)
    VALUES ("A1", "A015");

INSERT INTO Address (unit_number, apartment_number)
    VALUES ("C", "C300");

INSERT INTO vehicle (color, model, make, registration_number)
    VALUES ("dark green", "Prius", "Toyota", "xAT0zHpTKj");

INSERT INTO vehicle (color, model, make, registration_number)
    VALUES ("apple green", "Ghost", "Tesla", "u09OFKN0U0");

INSERT INTO vehicle (color, model, make, registration_number)
    VALUES ("shiny green", "Ghost", "Tesla", "lDW7fJ0vC5");

INSERT INTO Owner (first_name, last_name, phone_number)
    VALUES ("Ava", "Womly", "2326931538");

INSERT INTO Owner (first_name, last_name, phone_number)
    VALUES ("Luce", "Morgenstern", "9996663330");

INSERT INTO Owner (first_name, last_name, phone_number)
    VALUES ("Beetley", "Morgenstern", "9639630369");

INSERT INTO Owner (first_name, last_name, phone_number)
    VALUES ("Burley", "Wrede", "2389891234");

INSERT INTO Owner (first_name, last_name, phone_number)
    VALUES ("Mina", "Wrede", "2389891234");

INSERT INTO VehicleOwner (vehicle_id, owner_id)
    VALUES ("3", "4");

INSERT INTO VehicleOwner (vehicle_id, owner_id)
    VALUES ("1", "4");

INSERT INTO VehicleOwner (vehicle_id, owner_id)
    VALUES ("3", "5");

INSERT INTO VehicleOwner (vehicle_id, owner_id)
    VALUES ("2", "1");

INSERT INTO VehicleOwner (vehicle_id, owner_id)
    VALUES ("2", "2");

INSERT INTO OwnerAddress (owner_id, address_id)
    VALUES ("1", "3");

INSERT INTO OwnerAddress (owner_id, address_id)
    VALUES ("2", "3");

INSERT INTO OwnerAddress (owner_id, address_id)
    VALUES ("4", "1");

INSERT INTO OwnerAddress (owner_id, address_id)
    VALUES ("5", "1");

INSERT INTO OwnerAddress (owner_id, address_id)
    VALUES ("3", "1");