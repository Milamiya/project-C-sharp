package GUI.FrameControlCongcu;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;
import javax.swing.border.LineBorder;
import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.table.DefaultTableModel;
import java.awt.Color;
import java.awt.Toolkit;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Vector;
import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.SwingUtilities;


public class TimKiemSach extends JFrame {
	private JTextField tfTenSach;
	private JTable table;
	Vector col = new Vector();
    Vector data = new Vector();
    DefaultListModel modelList = new DefaultListModel();
	JList list = new JList(modelList);
	
	public TimKiemSach() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(759, 250);
		setLocationRelativeTo(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/search.png")));
		setTitle("Tìm kiếm sách");
		setResizable(false);
		getContentPane().setLayout(null);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(new LineBorder(new Color(192, 192, 192)), "T\u00EAn s\u00E1ch", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 190, 195);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		tfTenSach = new JTextField();
		tfTenSach.setBounds(10, 26, 167, 20);
		panel.add(tfTenSach);
		tfTenSach.setColumns(10);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 57, 169, 127);
		panel.add(scrollPane);
		scrollPane.setViewportView(list);
		
		JScrollPane jsp = new JScrollPane();
		jsp.setBounds(204, 19, 539, 186);
		getContentPane().add(jsp);
		
		table = new JTable();
		col.add("Tên sách");
        col.add("Tên tác giả");
        col.add("SL");
		table.setModel(new DefaultTableModel(data, col));
		table.getColumnModel().getColumn(0).setPreferredWidth(270);
		table.getColumnModel().getColumn(1).setPreferredWidth(120);
		table.getColumnModel().getColumn(2).setPreferredWidth(8);
		jsp.setViewportView(table);
		
		tfTenSach.getDocument().addDocumentListener(new DocumentListener() {
			
			@Override
			public void removeUpdate(DocumentEvent arg0) {
				// TODO Auto-generated method stub
				
			}
			
			@Override
			public void insertUpdate(DocumentEvent arg0) {
				SwingUtilities.invokeLater(new Runnable()
				{
					public void run()
						{
							try {

								Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
								String sql = "SELECT TENSACH FROM SACH WHERE TENSACH LIKE '"+ tfTenSach.getText() + "%'";
								ResultSet rs = statement.executeQuery(sql);
								modelList.removeAllElements();
								data.clear();
								table.setModel(new DefaultTableModel(data, col));

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
			
			@Override
			public void valueChanged(ListSelectionEvent arg0) {		
				try {
					data.clear();
					table.setModel(new DefaultTableModel(data, col));
					String tensach = String.valueOf(list.getSelectedValue());
					Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
					String sql = String.format("SELECT TENSACH,TENTACGIA,SOLUONGCON FROM SACH,KHO,TACGIA WHERE SACH.MASACH = KHO.MASACH AND SACH.MATACGIA = TACGIA.MATACGIA AND TENSACH = '%s'",tensach);
					ResultSet rs = statement.executeQuery(sql);
			        
					while (rs.next()) {
						Vector row = new Vector();
		                for (int i = 1; i <= 3; i++) {
		                    row.add(rs.getString(i));
		                }
		                data.add(row);
		                table.setModel(new DefaultTableModel(data, col));
						table.getColumnModel().getColumn(0).setPreferredWidth(270);
						table.getColumnModel().getColumn(1).setPreferredWidth(120);
						table.getColumnModel().getColumn(2).setPreferredWidth(8);
					}

				} catch (Exception e) {
					e.printStackTrace();
				}
				
			}
		});
		
	}
	
	public static void main(String[] args) {
		new TimKiemSach().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

   

    
}

