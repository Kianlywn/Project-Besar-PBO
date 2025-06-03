-- ini dulu
CREATE TABLE IF NOT EXISTS users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    full_name VARCHAR(100) NOT NULL,
    role VARCHAR(20) NOT NULL DEFAULT 'kasir' -- 'admin' atau 'kasir'
);

--trus insert ini
INSERT INTO users (username, password, full_name, role)
VALUES ('admin', 'admin123', 'Administrator', 'admin');

-- ini dulu
CREATE SEQUENCE produk_id_seq;

-- trus ini
CREATE TABLE produk (
    id_produk TEXT PRIMARY DEFAULT 
      LPAD((nextval('produk_id_seq') % 100000)::TEXT, 3, '0') || 
      substr(md5(random()::TEXT), 1, 4),
    nama_produk VARCHAR(100) NOT NULL,
    jumlah_stok INTEGER NOT NULL DEFAULT 0,
    harga_per_unit DECIMAL(10, 2) NOT NULL
);

select * from users
select * from produk