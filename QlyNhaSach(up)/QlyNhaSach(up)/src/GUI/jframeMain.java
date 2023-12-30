package GUI;

import GUI.FrameControlTainguyen.KhaiBaoSach;
import GUI.Menu.JIFBanHang;
import GUI.Menu.JIFBaoCao;
import GUI.Menu.JIFTainguyen;
import GUI.Menu.JIFHeThong;
import GUI.Menu.JIFThongtin;
import GUI.Menu.JIFKhuyenmai;
import GUI.ThongTin;
//import GUI.Menu.JIFCongcu;
import GUI.Menu.JIFCongcu1;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import javax.swing.JLabel;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.beans.PropertyVetoException;
import java.net.URL;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.imageio.ImageIO;
import javax.swing.JComponent;
import javax.swing.JDesktopPane;
import javax.swing.JInternalFrame;
import javax.swing.JLabel;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;
import javax.swing.plaf.DesktopPaneUI;


/**
 *
 * @author 10520_000
 */
public class jframeMain extends javax.swing.JFrame implements ActionListener{
JLabel lbUser, lbquyen ;
    //AutoSuggest _tenKhach = null;
    public jframeMain() {
       lbUser = new JLabel("");
		lbUser.setForeground(Color.WHITE);
		lbUser.setFont(new Font("Times New Roman", Font.BOLD, 17));
		lbUser.setBackground(Color.WHITE);
		lbUser.setBounds(1180,665, 170, 26);
		getContentPane().add(lbUser);
     lbquyen = new JLabel("Đăng nhập với quyền:");
		lbquyen.setForeground(Color.WHITE);
		lbquyen.setFont(new Font("Times New Roman", Font.BOLD, 17));
		lbquyen.setBackground(Color.WHITE);
		lbquyen.setBounds(1015,665, 170, 26);
		getContentPane().add(lbquyen);
        this.setIconImage(Toolkit.getDefaultToolkit().getImage("src/Image/login.png"));
        
        
        initComponents();
              
        
        //Make dragging a little faster but perhaps uglier.        
         setExtendedState(MAXIMIZED_BOTH);
         
         // Set giao dien cac ChildFrom
         desktop.setUI(new DesktopPaneUI() {
             @Override
        public void installUI(JComponent c) {
            // TODO Auto-generated method stub
            try {
             // UIManager.setLookAndFeel("com.jtattoo.plaf.bernstein.BernsteinLookAndFeel");
               // UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");
                UIManager.setLookAndFeel("com.jtattoo.plaf.hifi.HiFiLookAndFeel");
               // UIManager.setLookAndFeel("com.jtattoo.plaf.texture.TextureLookAndFeel");
            } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | UnsupportedLookAndFeelException e) {
            }
            super.installUI(c);
        }          
        });
        
 
        JIFTainguyen frame;
        
        try {
            frame = new JIFTainguyen();
           // new loginJFrame().show();
           // dispose();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
                       
        } catch (PropertyVetoException ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    // Set kich thuoc cac tab menu
    private void setSize(JInternalFrame frm){
        frm.setSize(283, 270);
    }
  
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jInternalFrame1 = new javax.swing.JInternalFrame();
        desktopCN = new javax.swing.JDesktopPane();
        jLabel5 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jPanelTab = new javax.swing.JPanel();
        jButtonThongtin = new javax.swing.JButton();
        jButtonBanHang = new javax.swing.JButton();
        jButtonHeThong = new javax.swing.JButton();
        jButtonTainguyen = new javax.swing.JButton();
        jButtonThongtin1 = new javax.swing.JButton();
        jButtonKhuyenmai = new javax.swing.JButton();
        jButtonCongcu = new javax.swing.JButton();
        jButtonBaoCao = new javax.swing.JButton();
        jButtonLogout = new javax.swing.JButton();
        jButtonExit = new javax.swing.JButton();
        desktop = new javax.swing.JDesktopPane();

        jInternalFrame1.setVisible(true);

        javax.swing.GroupLayout jInternalFrame1Layout = new javax.swing.GroupLayout(jInternalFrame1.getContentPane());
        jInternalFrame1.getContentPane().setLayout(jInternalFrame1Layout);
        jInternalFrame1Layout.setHorizontalGroup(
            jInternalFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );
        jInternalFrame1Layout.setVerticalGroup(
            jInternalFrame1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 0, Short.MAX_VALUE)
        );

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("PHẦN MỀM QUẢN LÝ NHÀ SÁCH");
        setLocationByPlatform(true);

        desktopCN.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED));

        jLabel5.setFont(new java.awt.Font("Times New Roman", 1, 36)); // NOI18N
        jLabel5.setBounds(20, 100, 0, 0);
        desktopCN.add(jLabel5, javax.swing.JLayeredPane.DEFAULT_LAYER);

        jLabel3.setFont(new java.awt.Font("Times New Roman", 1, 48)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 255, 255));
        jLabel3.setText("HỆ THỐNG QUẢN LÝ NHÀ SÁCH");
        jLabel3.setBounds(140, 60, 830, 60);
        desktopCN.add(jLabel3, javax.swing.JLayeredPane.DEFAULT_LAYER);

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/Book.gif"))); // NOI18N
        jLabel1.setText("jLabel1");
        jLabel1.setBounds(480, 310, 260, 260);
        desktopCN.add(jLabel1, javax.swing.JLayeredPane.DEFAULT_LAYER);

        jLabel4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/img/1.png"))); // NOI18N
        jLabel4.setText("jLabel4");
        jLabel4.setBounds(10, 170, 310, 210);
        desktopCN.add(jLabel4, javax.swing.JLayeredPane.DEFAULT_LAYER);

        jLabel6.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/img/2.png"))); // NOI18N
        jLabel6.setText("jLabel6");
        jLabel6.setBounds(10, 390, 310, 153);
        desktopCN.add(jLabel6, javax.swing.JLayeredPane.DEFAULT_LAYER);

        jLabel7.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/img/3.png"))); // NOI18N
        jLabel7.setText("jLabel7");
        jLabel7.setBounds(10, 550, 150, 132);
        desktopCN.add(jLabel7, javax.swing.JLayeredPane.DEFAULT_LAYER);

        jLabel8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/data/img/4.png"))); // NOI18N
        jLabel8.setText("jLabel8");
        jLabel8.setBounds(170, 550, 150, 130);
        desktopCN.add(jLabel8, javax.swing.JLayeredPane.DEFAULT_LAYER);

        jPanelTab.setBackground(new java.awt.Color(51, 51, 51));
        jPanelTab.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED));
        jPanelTab.setForeground(new java.awt.Color(255, 255, 255));

        jButtonThongtin.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/home1.png"))); // NOI18N
        jButtonThongtin.setText("Lưu trữ thông tin");
        jButtonThongtin.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonThongtin.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonThongtinActionPerformed(evt);
            }
        });

        jButtonBanHang.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/ban.png"))); // NOI18N
        jButtonBanHang.setText("Quản lý bán hàng");
        jButtonBanHang.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonBanHang.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonBanHangActionPerformed(evt);
            }
        });

        jButtonHeThong.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/cp.png"))); // NOI18N
        jButtonHeThong.setText("Hệ thống");
        jButtonHeThong.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonHeThong.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonHeThongActionPerformed(evt);
            }
        });

        jButtonTainguyen.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/list1.png"))); // NOI18N
        jButtonTainguyen.setText("Quản lý tài nguyên sách");
        jButtonTainguyen.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonTainguyen.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonTainguyenActionPerformed(evt);
            }
        });

        jButtonThongtin1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/author.png"))); // NOI18N
        jButtonThongtin1.setText("Trợ giúp");
        jButtonThongtin1.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonThongtin1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonThongtin1ActionPerformed(evt);
            }
        });

        jButtonKhuyenmai.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/cp.png"))); // NOI18N
        jButtonKhuyenmai.setText("Chương trình khuyến mãi");
        jButtonKhuyenmai.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonKhuyenmai.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonKhuyenmaiActionPerformed(evt);
            }
        });

        jButtonCongcu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/chi.png"))); // NOI18N
        jButtonCongcu.setText("Công cụ");
        jButtonCongcu.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonCongcu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonCongcuActionPerformed(evt);
            }
        });

        jButtonBaoCao.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/report4.png"))); // NOI18N
        jButtonBaoCao.setText("Báo cáo");
        jButtonBaoCao.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonBaoCao.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonBaoCaoActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanelTabLayout = new javax.swing.GroupLayout(jPanelTab);
        jPanelTab.setLayout(jPanelTabLayout);
        jPanelTabLayout.setHorizontalGroup(
            jPanelTabLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelTabLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelTabLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButtonThongtin, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonBanHang, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonHeThong, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonTainguyen, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonThongtin1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonKhuyenmai, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonCongcu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jButtonBaoCao, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );
        jPanelTabLayout.setVerticalGroup(
            jPanelTabLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelTabLayout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jButtonTainguyen, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonThongtin, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonCongcu, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonBanHang, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonBaoCao, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonKhuyenmai, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonHeThong, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(5, 5, 5)
                .addComponent(jButtonThongtin1, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        jButtonLogout.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/logout.png"))); // NOI18N
        jButtonLogout.setText("Đăng xuất");
        jButtonLogout.setToolTipText("");
        jButtonLogout.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonLogoutActionPerformed(evt);
            }
        });

        jButtonExit.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/close1.png"))); // NOI18N
        jButtonExit.setText("Thoát");
        jButtonExit.setToolTipText("");
        jButtonExit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonExitActionPerformed(evt);
            }
        });

        desktop.setBorder(javax.swing.BorderFactory.createBevelBorder(javax.swing.border.BevelBorder.RAISED));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(20, 20, 20)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jButtonLogout, javax.swing.GroupLayout.DEFAULT_SIZE, 120, Short.MAX_VALUE)
                        .addGap(29, 29, 29)
                        .addComponent(jButtonExit, javax.swing.GroupLayout.PREFERRED_SIZE, 133, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jPanelTab, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(desktop))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(desktopCN, javax.swing.GroupLayout.DEFAULT_SIZE, 611, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(6, 6, 6)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(desktopCN)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(desktop, javax.swing.GroupLayout.PREFERRED_SIZE, 220, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jPanelTab, javax.swing.GroupLayout.PREFERRED_SIZE, 425, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jButtonExit)
                            .addComponent(jButtonLogout, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addContainerGap(35, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonTainguyenActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonTainguyenActionPerformed
        // TODO add your handling code here:
        JIFTainguyen frame;
        try {
            frame = new JIFTainguyen();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
            
        } catch (PropertyVetoException ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonTainguyenActionPerformed

    private void jButtonThongtinActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonThongtinActionPerformed
        // TODO add your handling code here:
        JIFThongtin frame;
        try {
            frame = new JIFThongtin();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
            
        } catch (PropertyVetoException ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonThongtinActionPerformed

    private void jButtonBanHangActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonBanHangActionPerformed
        // TODO add your handling code here:
        JIFBanHang frame;
        try {
            frame = new JIFBanHang();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
            
        } catch (PropertyVetoException ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonBanHangActionPerformed

    private void jButtonCongcuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCongcuActionPerformed
        // TODO add your handling code here:
        JIFCongcu1 frame;
        try {
            frame = new JIFCongcu1();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
            
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonCongcuActionPerformed

    private void jButtonHeThongActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonHeThongActionPerformed
        // TODO add your handling code here:
        JIFHeThong frame;
        try {
            frame = new JIFHeThong();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
            
        } catch (PropertyVetoException ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonHeThongActionPerformed

    private void jButtonExitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonExitActionPerformed
        // TODO add your handling code here:
        System.exit(0);
    }//GEN-LAST:event_jButtonExitActionPerformed

    private void jButtonLogoutActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonLogoutActionPerformed
       new Login().show();
       dispose();        
    }//GEN-LAST:event_jButtonLogoutActionPerformed

    private void jButtonThongtin1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonThongTinActionPerformed
        // TODO add your handling code here:
       new ThongTin().show();
             
    }//GEN-LAST:event_jButtonThongTinActionPerformed

    private void jButtonKhuyenmaiActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonKhuyenmaiActionPerformed
        // TODO add your handling code here:
        JIFKhuyenmai frame;
        try {
            frame = new JIFKhuyenmai();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
            
        } catch (PropertyVetoException ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonKhuyenmaiActionPerformed

    private void jButtonBaoCaoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonBaoCaoActionPerformed
        // TODO add your handling code here:
         JIFBaoCao frame;
        try {
            frame = new JIFBaoCao();
            setSize(frame);
            frame.setVisible(true);
            frame.setDesktop(desktopCN);
            desktop.add(frame);
            frame.setSelected(true);
            
        } catch (PropertyVetoException ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonBaoCaoActionPerformed

    
    
    public void setTenUser(String username){ 
		this.lbUser.setText(username);
	}
    public static void main(String args[]) 
    {
       
        try 
        {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) 
            {
                if ("Nimbus".equals(info.getName())) 
                {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    //javax.swing.UIManager.setLookAndFeel("com.jtattoo.plaf.bernstein.BernsteinLookAndFeel");
                    break;
                }
            }
        }
        catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) 
        {
            
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() 
        {
            @Override
            public void run() {
                new jframeMain().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JDesktopPane desktop;
    private javax.swing.JDesktopPane desktopCN;
    private javax.swing.JButton jButtonBanHang;
    private javax.swing.JButton jButtonBaoCao;
    private javax.swing.JButton jButtonCongcu;
    private javax.swing.JButton jButtonExit;
    private javax.swing.JButton jButtonHeThong;
    private javax.swing.JButton jButtonKhuyenmai;
    private javax.swing.JButton jButtonLogout;
    private javax.swing.JButton jButtonTainguyen;
    private javax.swing.JButton jButtonThongtin;
    private javax.swing.JButton jButtonThongtin1;
    private javax.swing.JInternalFrame jInternalFrame1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JPanel jPanelTab;
    // End of variables declaration//GEN-END:variables
    
     

    @Override
    public void actionPerformed(ActionEvent e) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    private Object getDesktop() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    
}
