#!/bin/bash
# Salve este arquivo como base64_app.sh e torne executável: chmod +x base64_app.sh

python3 - <<'END_PYTHON'
import tkinter as tk
from tkinter import messagebox, scrolledtext
import base64

def encode_text():
    text = input_text.get("1.0", tk.END).strip()
    if text:
        encoded = base64.b64encode(text.encode()).decode()
        output_text.config(state=tk.NORMAL)
        output_text.delete("1.0", tk.END)
        output_text.insert(tk.END, encoded)
        output_text.config(state=tk.DISABLED)
        status_var.set("Texto codificado em Base64!")
    else:
        status_var.set("Nenhum texto para codificar.")

def decode_text():
    text = input_text.get("1.0", tk.END).strip()
    if text:
        try:
            decoded = base64.b64decode(text.encode()).decode()
            output_text.config(state=tk.NORMAL)
            output_text.delete("1.0", tk.END)
            output_text.insert(tk.END, decoded)
            output_text.config(state=tk.DISABLED)
            status_var.set("Texto decodificado com sucesso!")
        except Exception:
            status_var.set("Erro: Texto inválido para decodificar.")
    else:
        status_var.set("Nenhum texto para decodificar.")

def copy_result():
    text = output_text.get("1.0", tk.END).strip()
    if text:
        root.clipboard_clear()
        root.clipboard_append(text)
        status_var.set("Resultado copiado para a área de transferência.")
    else:
        status_var.set("Não há resultado para copiar.")

def transfer_result():
    text = output_text.get("1.0", tk.END).strip()
    if text:
        input_text.delete("1.0", tk.END)
        input_text.insert(tk.END, text)
        status_var.set("Resultado transferido para a entrada.")
    else:
        status_var.set("Não há resultado para transferir.")

# Janela principal
root = tk.Tk()
root.title("Base64 Encoder/Decoder")
root.geometry("800x650")

# Painel de entrada
tk.Label(root, text="Texto:", font=("SansSerif", 12)).pack(anchor="w", padx=10, pady=(10,0))
input_text = scrolledtext.ScrolledText(root, height=8, font=("SansSerif", 14))
input_text.pack(fill="both", padx=10, pady=5)

# Painel de botões
button_frame = tk.Frame(root)
button_frame.pack(pady=10)

tk.Button(button_frame, text="Encode", width=16, bg="#4CAF50", fg="white", command=encode_text).pack(side="left", padx=5)
tk.Button(button_frame, text="Decode", width=16, bg="#2196F3", fg="white", command=decode_text).pack(side="left", padx=5)
tk.Button(button_frame, text="Copiar Resultado", width=16, bg="#FFC107", fg="white", command=copy_result).pack(side="left", padx=5)
tk.Button(button_frame, text="Resultado -> Entrada", width=20, bg="#9C27B0", fg="white", command=transfer_result).pack(side="left", padx=5)

# Painel de resultado
tk.Label(root, text="Resultado:", font=("SansSerif", 12)).pack(anchor="w", padx=10, pady=(10,0))
output_text = scrolledtext.ScrolledText(root, height=8, font=("Monospaced", 14), state=tk.DISABLED)
output_text.pack(fill="both", padx=10, pady=5)

# Barra de status
status_var = tk.StringVar(value="Pronto")
status_bar = tk.Label(root, textvariable=status_var, bd=1, relief=tk.SUNKEN, anchor="w")
status_bar.pack(fill="x", side="bottom")

root.mainloop()
END_PYTHON
