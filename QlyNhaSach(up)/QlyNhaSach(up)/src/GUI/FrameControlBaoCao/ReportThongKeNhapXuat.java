package GUI.FrameControlBaoCao;

import javax.swing.JFrame;
import java.awt.Container;
import java.awt.Toolkit;

import net.sf.jasperreports.engine.*;
import net.sf.jasperreports.view.*;

public class ReportThongKeNhapXuat extends JFrame {
	
	public  ReportThongKeNhapXuat(String fileName){
		super("Thống kê số lượng nhập và bán ra của mỗi cuốn sách");
        try {
            JasperPrint print = JasperFillManager.fillReport(fileName, null, ketnoi.ConnectDB.getConnection());
            JRViewer viewer = new JRViewer(print);

            Container c = getContentPane();
            c.add(viewer);
        } catch (Exception ex) {
            ex.printStackTrace();
        }

        setSize(600, 500);
        setDefaultCloseOperation(DISPOSE_ON_CLOSE);
        setLocationRelativeTo(null);
        setIconImage(Toolkit.getDefaultToolkit().getImage(GUI.Login.class.getResource("/data/img/report.png")));
	}
	
	public static void main(String[] args) {
		ReportThongKeNhapXuat viewer = new ReportThongKeNhapXuat("Report/rp_TkSachTheoThang.jasper");
		viewer.setVisible(true);
	}

}
