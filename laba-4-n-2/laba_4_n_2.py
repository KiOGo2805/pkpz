import tkinter as tk
from tkinter import messagebox, scrolledtext
import os
import re


class TextFileApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Task 2 — Text File Processor")
        self.root.geometry("700x640")
        self.root.config(bg="#f2f2f2")

        self.file1 = "TF_1.txt"
        self.file2 = "TF_2.txt"

        tk.Label(
            root, text="Text File Processor",
            font=("Segoe UI", 18, "bold"),
            fg="#1A237E", bg="#f2f2f2"
        ).pack(pady=10)

        tk.Label(
            root, text="Enter text for TF_1 file:",
            font=("Segoe UI", 11, "bold"), bg="#f2f2f2"
        ).pack(anchor="w", padx=25)
        self.text_input = scrolledtext.ScrolledText(
            root, wrap=tk.WORD, width=75, height=10, font=("Segoe UI", 10)
        )
        self.text_input.pack(padx=25, pady=5)

        frame_btns = tk.Frame(root, bg="#f2f2f2")
        frame_btns.pack(pady=10)

        self.btn_create = tk.Button(
            frame_btns, text="📝 Create TF_1",
            bg="#90CAF9", font=("Segoe UI", 10, "bold"),
            width=15, command=self.create_file
        )
        self.btn_create.grid(row=0, column=0, padx=10)

        self.btn_remove = tk.Button(
            frame_btns, text="❌ Remove Word",
            bg="#A5D6A7", font=("Segoe UI", 10, "bold"),
            width=15, command=self.remove_word
        )
        self.btn_remove.grid(row=0, column=1, padx=10)

        self.btn_show = tk.Button(
            frame_btns, text="📂 Show TF_2",
            bg="#CE93D8", font=("Segoe UI", 10, "bold"),
            width=15, command=self.show_tf2
        )
        self.btn_show.grid(row=0, column=2, padx=10)

        word_frame = tk.Frame(root, bg="#f2f2f2")
        word_frame.pack(pady=(0, 10))
        tk.Label(
            word_frame, text="Word to remove:",
            font=("Segoe UI", 10, "bold"), bg="#f2f2f2"
        ).pack(side="left", padx=(25, 5))
        self.entry_word = tk.Entry(word_frame, width=25, font=("Segoe UI", 10))
        self.entry_word.pack(side="left", padx=5)

        tk.Label(
            root, text="Content of TF_2 file:",
            font=("Segoe UI", 11, "bold"), bg="#f2f2f2"
        ).pack(anchor="w", padx=25, pady=(15, 0))
        self.text_output = scrolledtext.ScrolledText(
            root, wrap=tk.WORD, width=75, height=10,
            font=("Segoe UI", 10), bg="#FAFAFA", state="disabled"
        )
        self.text_output.pack(padx=25, pady=5)

    def create_file(self):
        text = self.text_input.get("1.0", tk.END).strip()
        if not text:
            messagebox.showwarning("Warning", "Please enter some text first!")
            return
        try:
            with open(self.file1, "w", encoding="utf-8") as f:
                f.write(text)
            messagebox.showinfo("Success", f"File '{self.file1}' created successfully.")
        except Exception as e:
            messagebox.showerror("Error", str(e))

    def remove_word(self):
        if not os.path.exists(self.file1):
            messagebox.showwarning("Warning", f"File '{self.file1}' not found!")
            return

        word = self.entry_word.get().strip()
        if not word:
            messagebox.showwarning("Warning", "Please enter a word to remove.")
            return

        try:
            with open(self.file1, "r", encoding="utf-8") as f1:
                lines = f1.readlines()

            new_lines = []
            for line in lines:
                clean_line = re.sub(rf'\b{re.escape(word)}\b', '', line, flags=re.IGNORECASE)
                new_lines.append(clean_line.strip())

            with open(self.file2, "w", encoding="utf-8") as f2:
                f2.write("\n".join(new_lines))

            messagebox.showinfo("Success", f"Word '{word}' removed. File '{self.file2}' created.")
        except Exception as e:
            messagebox.showerror("Error", str(e))

    def show_tf2(self):
        if not os.path.exists(self.file2):
            messagebox.showwarning("Warning", f"File '{self.file2}' not found!")
            return

        try:
            with open(self.file2, "r", encoding="utf-8") as f:
                content = f.read()

            self.text_output.config(state="normal")
            self.text_output.delete("1.0", tk.END)
            self.text_output.insert(tk.END, content if content else "(File is empty)")
            self.text_output.config(state="disabled")
        except Exception as e:
            messagebox.showerror("Error", str(e))


if __name__ == "__main__":
    root = tk.Tk()
    app = TextFileApp(root)
    root.mainloop()
