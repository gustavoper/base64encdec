import javax.swing.*;
import java.awt.*;
import java.awt.datatransfer.StringSelection;
import java.util.Base64;

public class Base64App extends JFrame {

    private JTextArea inputText;
    private JTextArea outputText;
    private JLabel statusBar;

    public Base64App() {
        setTitle("Base64 Encoder/Decoder");
        setSize(800, 650);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLocationRelativeTo(null);

        // Painel principal com BorderLayout
        JPanel panel = new JPanel(new BorderLayout(10, 10));
        panel.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        panel.setBackground(Color.WHITE);

        // Painel de entrada
        JPanel inputPanel = new JPanel(new BorderLayout(5, 5));
        inputPanel.setBackground(Color.WHITE);
        inputPanel.add(new JLabel("Texto:"), BorderLayout.NORTH);

        inputText = new JTextArea(5, 30);
        inputText.setLineWrap(true);
        inputText.setWrapStyleWord(true);
        inputText.setFont(new Font("SansSerif", Font.PLAIN, 14));
        JScrollPane inputScroll = new JScrollPane(inputText);
        inputPanel.add(inputScroll, BorderLayout.CENTER);

        panel.add(inputPanel, BorderLayout.NORTH);

        // Painel central vertical para botões + resultado
        JPanel centerPanel = new JPanel();
        centerPanel.setLayout(new BoxLayout(centerPanel, BoxLayout.Y_AXIS));
        centerPanel.setBackground(Color.WHITE);

        // Painel de botões horizontal
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 10, 5));
        buttonPanel.setBackground(Color.WHITE);

        JButton encodeButton = createStyledButton("Encode", new Color(76, 175, 80));
        JButton decodeButton = createStyledButton("Decode", new Color(33, 150, 243));
        JButton copyButton = createStyledButton("Copiar Resultado", new Color(255, 193, 7));
        JButton transferButton = createStyledButton(" Resultado <-> Texto", new Color(156, 39, 176));

        buttonPanel.add(encodeButton);
        buttonPanel.add(decodeButton);
        buttonPanel.add(copyButton);
        buttonPanel.add(transferButton);

        centerPanel.add(buttonPanel);

        // Painel de resultado
        JPanel outputPanel = new JPanel(new BorderLayout(5, 5));
        outputPanel.setBackground(Color.WHITE);
        outputPanel.setBorder(BorderFactory.createEmptyBorder(10, 0, 0, 0));
        outputPanel.add(new JLabel("Resultado:"), BorderLayout.NORTH);

        outputText = new JTextArea(5, 30);
        outputText.setEditable(false);
        outputText.setLineWrap(true);
        outputText.setWrapStyleWord(true);
        outputText.setFont(new Font("Monospaced", Font.PLAIN, 14));
        JScrollPane outputScroll = new JScrollPane(outputText);
        outputPanel.add(outputScroll, BorderLayout.CENTER);

        centerPanel.add(outputPanel);

        panel.add(centerPanel, BorderLayout.CENTER);

        // Barra de status
        statusBar = new JLabel("Pronto");
        statusBar.setBorder(BorderFactory.createEmptyBorder(5, 5, 5, 5));
        statusBar.setOpaque(true);
        statusBar.setBackground(new Color(240, 240, 240));
        panel.add(statusBar, BorderLayout.SOUTH);

        add(panel);

        // Ações dos botões
        encodeButton.addActionListener(e -> {
            String text = inputText.getText();
            if (!text.isEmpty()) {
                outputText.setText(Base64.getEncoder().encodeToString(text.getBytes()));
                setStatus("Texto codificado em Base64!");
            } else {
                setStatus("Nenhum texto para codificar.");
            }
        });

        decodeButton.addActionListener(e -> {
            String text = inputText.getText();
            if (!text.isEmpty()) {
                try {
                    outputText.setText(new String(Base64.getDecoder().decode(text)));
                    setStatus("Texto decodificado com sucesso!");
                } catch (IllegalArgumentException ex) {
                    setStatus("Erro: Texto inválido para decodificar.");
                }
            } else {
                setStatus("Nenhum texto para decodificar.");
            }
        });

        copyButton.addActionListener(e -> {
            String result = outputText.getText();
            if (!result.isEmpty()) {
                StringSelection selection = new StringSelection(result);
                Toolkit.getDefaultToolkit().getSystemClipboard().setContents(selection, null);
                setStatus("Resultado copiado para a área de transferência.");
            } else {
                setStatus("Não há resultado para copiar.");
            }
        });

        transferButton.addActionListener(e -> {
            String result = outputText.getText();
            if (!result.isEmpty()) {
                inputText.setText(result);
                setStatus("Resultado transferido para a entrada.");
            } else {
                setStatus("Não há resultado para transferir.");
            }
        });
    }

    private JButton createStyledButton(String text, Color color) {
        JButton button = new JButton(text);
        button.setFocusPainted(false);
        button.setBackground(color);
        button.setForeground(Color.WHITE);
        button.setFont(new Font("SansSerif", Font.BOLD, 14));
        button.setBorder(BorderFactory.createEmptyBorder(8, 16, 8, 16));
        button.setCursor(new Cursor(Cursor.HAND_CURSOR));
        return button;
    }

    private void setStatus(String message) {
        statusBar.setText(message);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new Base64App().setVisible(true));
    }
}
