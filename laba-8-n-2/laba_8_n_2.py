import tkinter as tk
from tkinter import ttk, messagebox
from collections import namedtuple

IngredientPrices = namedtuple("IngredientPrices", 
                              ["ing1", "ing2", "ing3", "ing4", "ing5", "ing6"])

def get_price(product: str, ingredients_price: IngredientPrices, shipping_price: float) -> str:
    
    total_ingredient_cost = sum(ingredients_price)
    ip = total_ingredient_cost / len(ingredients_price)
    
    market_price = (0.75 * ip) + (1.15 * shipping_price)
    
    output_string = (f"The market price of product {product} "
                     f"is {market_price:.2f}.")
    
    return output_string

class PriceCalculatorApp(tk.Tk):
    
    def __init__(self):
        super().__init__()
        self.title("Market Price Calculator")
        self.geometry("600x650")
        self.resizable(False, False)
        
        self.ingredient_entries = {}
        
        self.setup_ui()

    def setup_ui(self):
        main_frame = ttk.LabelFrame(self, text="Input Data", padding="15")
        main_frame.pack(padx=15, pady=15, fill="x")
        
        ttk.Label(main_frame, text="Product Name:").grid(row=0, column=0, padx=5, pady=10, sticky="w")
        self.entry_product = ttk.Entry(main_frame, width=30)
        self.entry_product.grid(row=0, column=1, padx=5, pady=10)
        
        ttk.Label(main_frame, text="Shipping Price:").grid(row=1, column=0, padx=5, pady=10, sticky="w")
        self.entry_shipping = ttk.Entry(main_frame, width=30)
        self.entry_shipping.grid(row=1, column=1, padx=5, pady=10)

        ingredients_frame = ttk.LabelFrame(self, text="Prices of 6 Ingredients", padding="15")
        ingredients_frame.pack(padx=15, pady=5, fill="x")
        
        for i in range(6):
            label = f"Ingredient {i+1}:"
            ttk.Label(ingredients_frame, text=label).grid(row=i, column=0, padx=5, pady=5, sticky="w")
            
            entry = ttk.Entry(ingredients_frame, width=20)
            entry.grid(row=i, column=1, padx=5, pady=5)
            self.ingredient_entries[f"ing{i+1}"] = entry

        self.calc_button = ttk.Button(self, text="Calculate Price", command=self.calculate_market_price)
        self.calc_button.pack(pady=15)
        
        self.result_label = ttk.Label(self, text="Result:", font=("Segoe UI", 10, "bold"))
        self.result_label.pack(pady=(5, 0))
        
        self.output_text_var = tk.StringVar()
        self.output_label = ttk.Label(self, textvariable=self.output_text_var, 
                                      font=("Segoe UI", 11), wraplength=550)
        self.output_label.pack(pady=10, padx=15)

    def calculate_market_price(self):
        try:
            product_name = self.entry_product.get()
            shipping_cost = float(self.entry_shipping.get())
            
            if not product_name:
                raise ValueError("Product name cannot be empty.")

            prices = []
            for entry_widget in self.ingredient_entries.values():
                prices.append(float(entry_widget.get()))
            
            prices_tuple = IngredientPrices(*prices)
            
            result_string = get_price(product_name, prices_tuple, shipping_cost)
            
            self.output_text_var.set(result_string)

        except ValueError as e:
            messagebox.showerror("Input Error", 
                                 f"Invalid data: {e}\n\n"
                                 "Please check that all fields are filled "
                                 "and prices are entered as numbers.")
        except Exception as e:
            messagebox.showerror("Unexpected Error", f"An error occurred: {e}")

if __name__ == "__main__":
    app = PriceCalculatorApp()
    app.mainloop()