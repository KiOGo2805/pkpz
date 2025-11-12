import tkinter as tk
from tkinter import ttk, messagebox, scrolledtext
from collections import deque # Will be used as a Queue

# ----------------------------------------------------
# 1. BINARY TREE LOGIC
# ----------------------------------------------------

class Node:
    """Node of a Binary Search Tree (BST)."""
    def __init__(self, data):
        self.data = data  # e.g., Department name
        self.left = None
        self.right = None

class BinarySearchTree:
    """Class that implements the BST logic."""
    
    def __init__(self):
        self.root = None

    # --- 1. Insert element ---
    def insert(self, data):
        self.root = self._insert_recursive(self.root, data)
        return True 

    def _insert_recursive(self, node, data):
        if node is None:
            return Node(data)
        
        if data < node.data:
            node.left = self._insert_recursive(node.left, data)
        elif data > node.data:
            node.right = self._insert_recursive(node.right, data)
        
        return node

    # --- 2. Search in binary tree ---
    def search(self, data):
        return self._search_recursive(self.root, data)

    def _search_recursive(self, node, data):
        if node is None:
            return False # Not found
        
        if data == node.data:
            return True # Found
        elif data < node.data:
            return self._search_recursive(node.left, data)
        else:
            return self._search_recursive(node.right, data)

    # --- 3. Delete element ---
    def delete(self, data):
        if not self.search(data):
            return False # Element doesn't exist
        self.root = self._delete_recursive(self.root, data)
        return True 

    def _delete_recursive(self, node, data):
        if node is None:
            return node

        if data < node.data:
            node.left = self._delete_recursive(node.left, data)
        elif data > node.data:
            node.right = self._delete_recursive(node.right, data)
        else:
            # Found the node to delete
            # Case 1: No child or one child
            if node.left is None:
                return node.right
            elif node.right is None:
                return node.left
            
            # Case 2: Two children
            temp = self._find_min(node.right)
            node.data = temp.data 
            node.right = self._delete_recursive(node.right, temp.data)
            
        return node

    def _find_min(self, node):
        current = node
        while current.left is not None:
            current = current.left
        return current

    # --- 4. Tree traversal (VIA QUEUE) ---
    def traverse_level_order(self):
        """
        Implements "tree traversal via queue" (Breadth-First Search).
        """
        if self.root is None:
            return []
        
        results = []
        queue = deque([self.root]) # Create a queue

        while queue:
            # Dequeue the first element
            node = queue.popleft()
            results.append(str(node.data))
            
            # Enqueue children (to the END of the queue)
            if node.left:
                queue.append(node.left)
            if node.right:
                queue.append(node.right)
                
        return results

# ----------------------------------------------------
# 2. GRAPHICAL USER INTERFACE (GUI) CLASS
# ----------------------------------------------------
class UniversityApp(tk.Tk):
    
    def __init__(self):
        super().__init__()
        self.title("Lab 10 (Python): University Structure (BST)")
        self.geometry("600x450")
        self.resizable(False, False)
        
        self.tree = BinarySearchTree()
        
        self.setup_ui()
        self.refresh_display() # Initial refresh (will show "Tree is empty")

    def setup_ui(self):
        # --- Frame 1: Input ---
        input_frame = ttk.LabelFrame(self, text="Controls (Insert, Delete, Search)", padding="10")
        input_frame.pack(padx=10, pady=10, fill="x")
        
        ttk.Label(input_frame, text="Department Name:").grid(row=0, column=0, padx=5, pady=5, sticky="w")
        self.entry_data = ttk.Entry(input_frame, width=30)
        self.entry_data.grid(row=0, column=1, padx=5, pady=5)
        
        # Buttons
        self.btn_insert = ttk.Button(input_frame, text="Insert", command=self.on_insert)
        self.btn_insert.grid(row=1, column=0, pady=10, padx=5, sticky="ew")
        
        self.btn_delete = ttk.Button(input_frame, text="Delete", command=self.on_delete)
        self.btn_delete.grid(row=1, column=1, pady=10, padx=5, sticky="ew")
        
        self.btn_search = ttk.Button(input_frame, text="Search", command=self.on_search)
        self.btn_search.grid(row=1, column=2, pady=10, padx=5, sticky="ew")

        # --- Frame 2: Output (Traversal) ---
        output_frame = ttk.LabelFrame(self, text="Tree Traversal (Level-Order / Queue)", padding="10")
        output_frame.pack(padx=10, pady=5, fill="both", expand=True)

        self.txt_output = scrolledtext.ScrolledText(output_frame, height=15, font=("Consolas", 10), wrap="word")
        self.txt_output.pack(fill="both", expand=True)
        self.txt_output.config(state="disabled")

    def get_input(self):
        data = self.entry_data.get().strip()
        if not data:
            messagebox.showwarning("Input Error", "The 'Department Name' field cannot be empty.")
            return None
        return data

    def refresh_display(self):
        """Main traversal method (requirement 1.1)"""
        # Call the method that uses the QUEUE
        tree_data = self.tree.traverse_level_order()
        
        self.txt_output.config(state="normal")
        self.txt_output.delete("1.0", "end")
        
        if not tree_data:
            self.txt_output.insert("end", "Tree is empty.")
        else:
            self.txt_output.insert("end", " -> ".join(tree_data))
            
        self.txt_output.config(state="disabled")
        self.entry_data.delete(0, "end")

    # --- 3. Event Handlers (Requirements 1.1) ---
    def on_insert(self):
        data = self.get_input()
        if data:
            if self.tree.search(data):
                messagebox.showinfo("Result", f"Element '{data}' already exists in the tree.")
            else:
                self.tree.insert(data)
                messagebox.showinfo("Success", f"Element '{data}' was added.")
                self.refresh_display()

    def on_delete(self):
        data = self.get_input()
        if data:
            if self.tree.delete(data):
                messagebox.showinfo("Success", f"Element '{data}' was deleted.")
                self.refresh_display()
            else:
                messagebox.showerror("Error", f"Element '{data}' was not found in the tree.")

    def on_search(self):
        data = self.get_input()
        if data:
            found = self.tree.search(data)
            if found:
                messagebox.showinfo("Search Result", f"Yes, element '{data}' was FOUND in the tree.")
            else:
                messagebox.showinfo("Search Result", f"No, element '{data}' was NOT FOUND in the tree.")
            self.entry_data.delete(0, "end")

# ----------------------------------------------------
# 3. RUN THE APPLICATION
# ----------------------------------------------------
if __name__ == "__main__":
    app = UniversityApp()
    app.mainloop()