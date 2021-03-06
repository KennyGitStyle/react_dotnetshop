
import { useState, useEffect } from "react";
import { Product } from "../../app/models/product";
import ProductList from "./ProductList";


function Catalog() {
    const [products, setProducts] = useState<Product[]>([])

    useEffect(() => {
        fetch('http://localhost:5000/api/products')
            .then(response => response.json())
            .then(data => setProducts(data))
    }, [])


    return (
        <>
            <h1>Catalog</h1>
            <ProductList products={products} />
        </>
    );
}

export default Catalog;