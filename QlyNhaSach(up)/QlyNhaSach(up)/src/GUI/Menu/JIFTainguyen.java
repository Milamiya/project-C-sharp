
package GUI.Menu;

import GUI.FrameControlTainguyen.KhaiBaoSach;
import GUI.FrameControlTainguyen.NhapSach;
import GUI.FrameControlTainguyen.ChinhSuaThongTinSach;
import GUI.FrameControlTainguyen.HuyThongTinSach;
import java.beans.PropertyVetoException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JDesktopPane;
import java.sql.*;

/**
 *
 * @author 10520_000
 */
public class JIFTainguyen extends javax.swing.JInternalFrame {

    private JDesktopPane desktop;
    /**
     * Creates new form JIFTainguyen
     */
    public JIFTainguyen() throws PropertyVetoException {
        
        this.setFrameIcon(new ImageIcon("src/Image/login.png"));
       javax.swing.plaf.InternalFrameUI gui  = this.getUI();  
            ((javax.swing.plaf.basic.BasicInternalFrameUI)gui).setNorthPane(null);
        initComponents();
       
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTree1 = new javax.swing.JTree();
        jPanelTainguyen = new javax.swing.JPanel();
        jLabelTieuDe = new javax.swing.JLabel();
        jButtonHuyThongTinSach = new javax.swing.JButton();
        jButtonNhapSach = new javax.swing.JButton();
        jButtonKhaiBaoSach = new javax.swing.JButton();
        jButtonChinhSuaThongTinSach = new javax.swing.JButton();

        jScrollPane1.setViewportView(jTree1);

        setBorder(javax.swing.BorderFactory.createEtchedBorder());
        setClosable(true);
        setIconifiable(true);
        setMaximizable(true);
        setMaximumSize(new java.awt.Dimension(80, 80));

        jPanelTainguyen.setBorder(javax.swing.BorderFactory.createEtchedBorder());
        jPanelTainguyen.setPreferredSize(new java.awt.Dimension(238, 288));

        jLabelTieuDe.setBackground(new java.awt.Color(255, 153, 255));
        jLabelTieuDe.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabelTieuDe.setForeground(new java.awt.Color(255, 255, 255));
        jLabelTieuDe.setText("Quản lý tài nguyên sách");

        jButtonHuyThongTinSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/people2.png"))); // NOI18N
        jButtonHuyThongTinSach.setText("Hủy thông tin sách");
        jButtonHuyThongTinSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonHuyThongTinSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonHuyThongTinSachActionPerformed(evt);
            }
        });

        jButtonNhapSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/people3.png"))); // NOI18N
        jButtonNhapSach.setText("Nhập sách");
        jButtonNhapSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonNhapSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonNhapSachActionPerformed(evt);
            }
        });

        jButtonKhaiBaoSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/book.png"))); // NOI18N
        jButtonKhaiBaoSach.setText("Khai báo sách");
        jButtonKhaiBaoSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonKhaiBaoSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonKhaiBaoSachActionPerformed(evt);
            }
        });

        jButtonChinhSuaThongTinSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/list.png"))); // NOI18N
        jButtonChinhSuaThongTinSach.setText("Chỉnh sửa thông tin sách");
        jButtonChinhSuaThongTinSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonChinhSuaThongTinSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonChinhSuaThongTinSachActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanelTainguyenLayout = new javax.swing.GroupLayout(jPanelTainguyen);
        jPanelTainguyen.setLayout(jPanelTainguyenLayout);
        jPanelTainguyenLayout.setHorizontalGroup(
            jPanelTainguyenLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelTainguyenLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanelTainguyenLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabelTieuDe, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanelTainguyenLayout.createSequentialGroup()
                        .addGroup(jPanelTainguyenLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jButtonKhaiBaoSach, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButtonNhapSach, javax.swing.GroupLayout.DEFAULT_SIZE, 229, Short.MAX_VALUE)
                            .addComponent(jButtonHuyThongTinSach, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButtonChinhSuaThongTinSach, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 229, Short.MAX_VALUE))
                        .addContainerGap())))
        );
        jPanelTainguyenLayout.setVerticalGroup(
            jPanelTainguyenLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelTainguyenLayout.createSequentialGroup()
                .addComponent(jLabelTieuDe, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonKhaiBaoSach)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonNhapSach)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonChinhSuaThongTinSach)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonHuyThongTinSach)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 273, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelTainguyen, javax.swing.GroupLayout.DEFAULT_SIZE, 253, Short.MAX_VALUE)
                    .addContainerGap()))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 231, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelTainguyen, javax.swing.GroupLayout.PREFERRED_SIZE, 201, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(19, Short.MAX_VALUE)))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonHuyThongTinSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonHuyThongTinSachActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
       // desktop.removeAll();
        HuyThongTinSach frame;
        try {
            frame = new HuyThongTinSach();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonHuyThongTinSachActionPerformed

    private void jButtonNhapSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonNhapSachActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
        //desktop.removeAll();
        NhapSach frame;
        frame = new NhapSach();
        frame.setVisible(true);
        getDesktop().add(frame);
        
    }//GEN-LAST:event_jButtonNhapSachActionPerformed

    private void jButtonKhaiBaoSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonKhaiBaoSachActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
        //desktop.removeAll();
        KhaiBaoSach frame;
        try {
            frame = new KhaiBaoSach();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonKhaiBaoSachActionPerformed

    private void jButtonChinhSuaThongTinSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonChinhSuaThongTinSachActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
        desktop.getComponent(0).setVisible(false);
       // desktop.removeAll();
        ChinhSuaThongTinSach frame;
        try {
            frame = new ChinhSuaThongTinSach();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonChinhSuaThongTinSachActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonChinhSuaThongTinSach;
    private javax.swing.JButton jButtonHuyThongTinSach;
    private javax.swing.JButton jButtonKhaiBaoSach;
    private javax.swing.JButton jButtonNhapSach;
    private javax.swing.JLabel jLabelTieuDe;
    private javax.swing.JPanel jPanelTainguyen;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTree jTree1;
    // End of variables declaration//GEN-END:variables

    /**
     * @return the desktop
     */
    public JDesktopPane getDesktop() {
        return desktop;
    }

    
    public void setDesktop(JDesktopPane desktop) {
        this.desktop = desktop;
    }

  
}
