package GUI.FrameControlThongtin;

//import .*;
import java.awt.Cursor;
import java.awt.Toolkit;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.Vector;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.table.DefaultTableModel;
import javax.swing.JTable;
import javax.swing.JScrollPane;
import javax.swing.border.TitledBorder;
import javax.swing.JLabel;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JTextField;
import javax.swing.JButton;


public class LoaiSach extends JFrame {
	Vector col = new Vector();
    Vector data = new Vector();
    private JTable table;
    private JTextField tfMaLoaiSach;
    private JTextField tfTenLoaiSach;

	public LoaiSach() {
		setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
		setSize(475, 220);
		getContentPane().setLayout(null);
		setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.FrameControlCongcu.TimMaSach.class.getResource("/data/img/kb.png")));
		setTitle("Loại sách");
		setResizable(false);
		setLocationRelativeTo(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(13, 75, 261, 102);
		getContentPane().add(scrollPane);
		
		table = new JTable();
		table.setModel(new DefaultTableModel(data, col));
		scrollPane.setViewportView(table);
		
		JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(null, "Thông tin loại sách", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 447, 60);
		getContentPane().add(panel);
		panel.setLayout(null);
		
		JLabel lbMaLoaiSach = new JLabel("Mã loại sách");
		lbMaLoaiSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbMaLoaiSach.setBounds(10, 32, 71, 14);
		panel.add(lbMaLoaiSach);
		
		JLabel lbTenLoaiSach = new JLabel("Tên loại sách");
		lbTenLoaiSach.setFont(new Font("Times New Roman", Font.PLAIN, 14));
		lbTenLoaiSach.setBounds(196, 32, 81, 14);
		panel.add(lbTenLoaiSach);
		
		tfMaLoaiSach = new JTextField();
		tfMaLoaiSach.setBounds(91, 30, 81, 20);
		panel.add(tfMaLoaiSach);
		tfMaLoaiSach.setColumns(10);
		
		tfTenLoaiSach = new JTextField();
		tfTenLoaiSach.setColumns(10);
		tfTenLoaiSach.setBounds(287, 30, 149, 20);
		panel.add(tfTenLoaiSach);
		
		JButton bThem = new JButton("Thêm");
		bThem.setBounds(280, 112, 177, 30);
		bThem.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bThem.setContentAreaFilled(false);
		getContentPane().add(bThem);
		
		JButton bSua = new JButton("Sửa");
		bSua.setBounds(280, 75, 177, 30);
		bSua.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bSua.setContentAreaFilled(false);
		getContentPane().add(bSua);
		
		JButton bReset = new JButton("Reset");
		bReset.setBounds(280, 148, 177, 30);
		bReset.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		bReset.setContentAreaFilled(false);
		getContentPane().add(bReset);
		
		LoadTable();
		
		tfMaLoaiSach.addMouseListener(new MouseAdapter() {
			public void mouseExited(MouseEvent ev) {
				try {
					
					if(tfMaLoaiSach.getText().length()>2){
						JOptionPane.showMessageDialog(null,"Mã loại sách không đúng quy định");
						tfMaLoaiSach.requestFocus();
					}
					
					else{
						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql = "SELECT MALOAISACH FROM LOAISACH";
						ResultSet rs = statement.executeQuery(sql);
						
						while(rs.next()){
							if(tfMaLoaiSach.getText().toUpperCase().equals(rs.getString("MALOAISACH"))){
								JOptionPane.showMessageDialog(null,"Mã loại sách bị trùng");
								tfMaLoaiSach.setText("");
							}
						}
					}
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
		
		bReset.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				
				tfMaLoaiSach.setText("");
				tfTenLoaiSach.setText("");
				LoadTable();
			}
		});
		
		bThem.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent ev) {
				String mals = tfMaLoaiSach.getText().toUpperCase();
				String tenls = tfTenLoaiSach.getText().toUpperCase();
				
				if(mals.equals("") || tenls.equals("")){
					JOptionPane.showMessageDialog(null, "Vui lòng điền thông tin đầy đủ","Thông báo",JOptionPane.INFORMATION_MESSAGE);
				}
				else if(mals.length()<2){
					JOptionPane.showMessageDialog(null,"Mã loại sách không đúng quy định");
					tfMaLoaiSach.requestFocus();
				}
				else{
					try {

						Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
						String sql1 = String.format("INSERT INTO LOAISACH VALUES ('%s','%s')", mals.toUpperCase(),tenls.toUpperCase());
						int n = statement.executeUpdate(sql1);
						
						if(n == 1){ 
					    	JOptionPane.showMessageDialog(null,"Thêm loại sách mới thành công","Hoàn tất",JOptionPane.INFORMATION_MESSAGE); 
					     }
						else{ 
							JOptionPane.showMessageDialog(null,"Lỗi!! Vui lòng kiểm tra lại","Thông báo",JOptionPane.ERROR_MESSAGE); 
						 }
						LoadTable();

					} catch (Exception e) {
						e.printStackTrace();
					}
				}
			}
		});
		
		table.addMouseListener(new MouseAdapter() {
			
			public void mouseClicked(MouseEvent arg0) {
				// TODO Auto-generated method stub
				int index = table.getSelectedRow();
				tfMaLoaiSach.setText(String.valueOf(table.getValueAt(index,0)));
				tfTenLoaiSach.setText(String.valueOf(table.getValueAt(index,1)));
			}
		});
		
		bSua.addActionListener(new ActionListener() {			
			@Override
			public void actionPerformed(ActionEvent ev) {
				int index = table.getSelectedRow();
				if(index == -1){
					JOptionPane.showMessageDialog(null, "Xin vui lòng chọn dòng cần sửa");
				}
				
				else{
					String mls = String.valueOf(table.getValueAt(index,0));
					if(tfMaLoaiSach.getText().equals("")||tfTenLoaiSach.getText().equals("")){
						JOptionPane.showMessageDialog(null,"Vui lòng điền đầy đủ thoongg tin");
					}
					
					else if(tfMaLoaiSach.getText().length()<2){
						JOptionPane.showMessageDialog(null,"Mã loại sách không đúng quy định");
						tfMaLoaiSach.requestFocus();
					}
			
					else{
						try {
							Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
							String sql = String.format("UPDATE LOAISACH SET MALOAISACH = '%s',TENLOAISACH = '%s' WHERE MALOAISACH = '%s'",tfMaLoaiSach.getText().toUpperCase(),tfTenLoaiSach.getText().toUpperCase(),mls);
							int n = statement.executeUpdate(sql);
							
							if(n==1){
								JOptionPane.showMessageDialog(null, "Chỉnh sửa thành công");
								LoadTable();
							}
							
							else{
								JOptionPane.showMessageDialog(null, "Lỗi!!");
							}

						} catch (Exception e) {
							e.printStackTrace();
						}	
					}
					
				}
			}
		});
		
		
	}
	
	public void LoadTable(){
		try {

			Statement statement = ketnoi.ConnectDB.getConnection().createStatement();
			String sql = "SELECT * FROM LOAISACH";
			ResultSet rs = statement.executeQuery(sql);
			Vector col = new Vector();
	        Vector data = new Vector();
	        col.add("Mã loại sách");
	        col.add("Tên loại sách");
	        

			while (rs.next()) {
				Vector row = new Vector();
                for (int i = 1; i <= 2; i++) {
                    row.add(rs.getString(i));
                }
                data.add(row);
			}
			table.setModel(new DefaultTableModel(data, col));

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		new LoaiSach().setVisible(true);
	}

    public void setSelected(boolean b) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}


