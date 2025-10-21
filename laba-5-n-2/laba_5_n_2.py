import tkinter as tk
from tkinter import messagebox, ttk


class Document:
    def __init__(self, title="Document", number=0, date="01.01.2025"):
        self.title = title
        self.number = number
        self.date = date

    def __del__(self):
        print("Lab work completed by a 2nd-year student Melnyk Stepan")

    def show(self):
        return f"Document: {self.title}\nNumber: {self.number}\nDate: {self.date}"

    def document_type(self):
        return "General Document"


class Receipt(Document):
    def __init__(self, title="Receipt", number=0, date="01.01.2025", payer="Unknown", amount=0.0):
        super().__init__(title, number, date)
        self.payer = payer
        self.amount = amount

    def show(self):
        return f"{super().show()}\nPayer: {self.payer}\nAmount: {self.amount} UAH"

    def document_type(self):
        return "Receipt"


class Invoice(Document):
    def __init__(self, title="Invoice", number=0, date="01.01.2025", supplier="Unknown", items=None):
        super().__init__(title, number, date)
        self.supplier = supplier
        self.items = items if items is not None else []

    def show(self):
        return f"{super().show()}\nSupplier: {self.supplier}\nItems: {', '.join(self.items) if self.items else 'none'}"

    def document_type(self):
        return "Invoice"


class Bill(Document):
    def __init__(self, title="Bill", number=0, date="01.01.2025", client="Unknown", total=0.0):
        super().__init__(title, number, date)
        self.client = client
        self.total = total

    def show(self):
        return f"{super().show()}\nClient: {self.client}\nTotal: {self.total} UAH"

    def document_type(self):
        return "Bill"


class DocumentApp(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("Laba 5_2")
        self.geometry("550x520")
        self.resizable(False, False)

        tk.Label(self, text="Document type:").pack(pady=5)
        self.doc_type = ttk.Combobox(self, values=["Receipt", "Invoice", "Bill"])
        self.doc_type.current(0)
        self.doc_type.pack()

        frame = tk.Frame(self)
        frame.pack(pady=10)

        self.entries = {}
        labels = ["Title", "Number", "Date", "Name", "Amount"]
        for label in labels:
            tk.Label(frame, text=label + ":").pack()
            entry = tk.Entry(frame, width=40)
            entry.pack(pady=2)
            self.entries[label] = entry

        tk.Button(self, text="Create", width=20, command=self.create_doc).pack(pady=5)
        tk.Button(self, text="Show", width=20, command=self.show_doc).pack(pady=5)

        tk.Label(self, text="Result:").pack()
        self.output = tk.Text(self, height=10, width=60)
        self.output.pack(pady=5)

        self.current_doc = None

    def create_doc(self):
        dtype = self.doc_type.get()
        title = self.entries["Title"].get() or dtype
        number = self.entries["Number"].get() or "0"
        date = self.entries["Date"].get() or "01.01.2025"
        pname = self.entries["Name"].get()
        amount = self.entries["Amount"].get()

        if dtype == "Receipt":
            self.current_doc = Receipt(title, number, date, payer=pname, amount=amount or 0)
        elif dtype == "Invoice":
            items = amount.split(",") if amount else []
            self.current_doc = Invoice(title, number, date, supplier=pname, items=items)
        elif dtype == "Bill":
            self.current_doc = Bill(title, number, date, client=pname, total=amount or 0)

        messagebox.showinfo("Created", f"{dtype} created successfully!")

    def show_doc(self):
        if self.current_doc:
            text = self.current_doc.show() + f"\nType: {self.current_doc.document_type()}"
            self.output.delete(1.0, tk.END)
            self.output.insert(tk.END, text)
        else:
            messagebox.showwarning("Error", "Create a document first!")


if __name__ == "__main__":
    app = DocumentApp()
    app.mainloop()
