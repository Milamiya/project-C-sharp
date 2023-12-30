package GUI.FrameControlCongcu;

import java.awt.Color;
import java.awt.Cursor;
import java.awt.Font;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import javax.swing.*;
import javax.swing.border.TitledBorder;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;

public class TimMaSach extends JFrame{
	
	private JTextField tfTenSach;
	private JTextField tfMaSach;
	DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	
	public TimMaSach(){
		
		setTitle("TÌM MÃ SÁCH");
		setIconImage(Toolkit.getDefaultToolkit().getImage(TimMaSach.class.getResource("/data/img/search.png")));
		setResizable(false);
		setSize(426,225);
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		getContentPane().setLayout(null);
		setLocationRelativeTo(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(null, "Tên sách", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 400, 147);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		tfTenSach = new JTextField();
		tfTenSach.setBounds(10, 21, 380, 20);
		panel.add(tfTenSach);
		tfTenSach.setColumns(10);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 52, 380, 84);
		panel.add(scrollPane);
		
		scrollPane.setViewportView(list);
		
		JLabel lbMaSach = new JLabel("Mã sách");
		lbMaSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaSach.setBounds(12, 169, 50, 19);
		getContentPane().add(lbMaSach);
		
		tfMaSach = new JTextField();
		tfMaSach.setEditable(false);
		tfMaSach.setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY));
		tfMaSach.setBounds(70, 169, 131, 20);
		getContentPane().add(tfMaSach);
		tfMaSach.setColumns(10);
		
		JButton bReset = new JButton("Reset");
		bReset.setBounds(220, 160, 89, 31);
		bReset.setContentAreaFilled(false);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		getContentPane().add(bReset);
		
		JButton bThoat = new JButton("Thoát");
		bThoat.setBounds(321, 160, 89, 31);
		bThoat.setContentAreaFilled(false);
		bThoat.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		getContentPane().add(bThoat);
		
		tfTenSach.getDocument().addDocumentListener(new DocumentListener() {

			@Override
			public void removeUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub

			}

			@Override
			public void insertUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				SwingUtilities.invokeLater(new Runnable()
				{
					public void run()
						{
						  try {

								Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
								String sql = "SELECT TENSACH FROM SACH WHERE TENSACH LIKE '"+ tfTenSach.getText() + "%'";
								ResultSet rs = statement.executeQuery(sql);
								modelList.removeAllElements();
								tfMaSach.setText("");

								while (rs.next()) {
									modelList.addElement(rs.getString("TENSACH"));
								}
								
								if(modelList.isEmpty()){
									JOptionPane.showMessageDialog(null,"Sách không có trong kho");
									tfTenSach.setText("");
								}

							} catch (Exception e) {
								e.printStackTrace();
							}
						}
				});		

			}

			@Override
			public void changedUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub

			}
		});

		list.addListSelectionListener(new ListSelectionListener() {
			public void valueChanged(ListSelectionEvent arg0) {
				try {
					String tensach = (String) list.getSelectedValue();
                    Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("SELECT MASACH FROM SACH WHERE TENSACH = '%s'",tensach);
					ResultSet rs = statement.executeQuery(sql);

					while (rs.next()) {
						tfMaSach.setText(rs.getString("MASACH"));
					}

				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		});
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				// TODO Auto-generated method stub
				tfMaSach.setText("");
				tfTenSach.setText("");
				modelList.removeAllElements();
				tfTenSach.requestFocus();
			}
		});
		
		bThoat.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				// TODO Auto-generated method stub
				dispose();
			}
		});
		
	}
	
	public static void main(String[] args) {
		new TimMaSach().setVisible(true);
	}

}

