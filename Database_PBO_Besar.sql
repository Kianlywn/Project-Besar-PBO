CREATE TABLE IF NOT EXISTS users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    full_name VARCHAR(100) NOT NULL,
    role VARCHAR(20) NOT NULL -- 'admin' atau 'kasir'
);

INSERT INTO users (username, password, full_name, role)
VALUES ('admin', 'admin123', 'Administrator', 'admin');


-- Tambahkan kolom id_user
ALTER TABLE kasir
ADD COLUMN id_user INT;

-- Tambahkan relasi foreign key ke tabel users
ALTER TABLE kasir
ADD CONSTRAINT fk_user_kasir
FOREIGN KEY (id_user)
REFERENCES users(id)
ON DELETE CASCADE;



INSERT INTO users (username, password)
VALUES ('Admin', 'admin123');

ALTER TABLE users
ADD COLUMN class VARCHAR(50) NOT NULL DEFAULT 'regular'; -- 'regular' sebagai nilai default

UPDATE kasir
SET nama_kasir = 'admin'
WHERE username = 'Admin';

DELETE FROM users WHERE username = 'Admin';

DROP TABLE IF EXISTS users;
select * from users
select * from kasir

SELECT id, username FROM users WHERE role = 'kasir';
