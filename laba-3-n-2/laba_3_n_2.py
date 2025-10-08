import re
import tkinter as tk
from tkinter import messagebox

def find_english_words():
    text = input_text.get("1.0", tk.END).strip()
    english_words = re.findall(r'\b[a-zA-Z]+\b', text)

    if not english_words:
        result_label.config(text="No English words found.")
    else:
        result_label.config(text=f"Found words: {', '.join(english_words)}\nCount: {len(english_words)}")

def remove_word():
    word = word_entry.get().strip()
    text = input_text.get("1.0", tk.END)

    if not word:
        messagebox.showwarning("Warning", "Enter a word to remove!")
        return

    new_text = re.sub(rf'\b{re.escape(word)}\b', '', text, flags=re.IGNORECASE)
    input_text.delete("1.0", tk.END)
    input_text.insert(tk.END, new_text)
    result_label.config(text=f"Word '{word}' has been removed.")

def replace_word():
    old_word = word_entry.get().strip()
    new_word = replace_entry.get().strip()
    text = input_text.get("1.0", tk.END)

    if not old_word or not new_word:
        messagebox.showwarning("Warning", "Enter both words for replacement!")
        return

    new_text = re.sub(rf'\b{re.escape(old_word)}\b', new_word, text, flags=re.IGNORECASE)
    input_text.delete("1.0", tk.END)
    input_text.insert(tk.END, new_text)
    result_label.config(text=f"Word '{old_word}' has been replaced with '{new_word}'.")

# --- GUI ---
root = tk.Tk()
root.title("English Words Processing")
root.geometry("700x500")

# Input text field
input_text = tk.Text(root, height=8, width=70)
input_text.pack(pady=10)

# Buttons
find_button = tk.Button(root, text="Find English words", command=find_english_words)
find_button.pack(pady=5)

# Word input fields
word_entry = tk.Entry(root, width=30)
word_entry.pack(pady=5)
word_entry.insert(0, "Enter a word")

replace_entry = tk.Entry(root, width=30)
replace_entry.pack(pady=5)
replace_entry.insert(0, "Replacement word")

# Action buttons
remove_button = tk.Button(root, text="Remove word", command=remove_word)
remove_button.pack(pady=5)

replace_button = tk.Button(root, text="Replace word", command=replace_word)
replace_button.pack(pady=5)

# Result label
result_label = tk.Label(root, text="", justify="center", wraplength=600)
result_label.pack(pady=20)

root.mainloop()
