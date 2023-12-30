package GUI.Menu;

import GUI.FrameControlThongtin.LinhVuc;
import GUI.FrameControlThongtin.LoaiSach;
import GUI.FrameControlThongtin.ThongTinXB;
import GUI.FrameControlThongtin.TacGia;
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
public class JIFThongtin extends javax.swing.JInternalFrame {

    private JDesktopPane desktop;
    /**
     * Creates new form JIFTainguyen
     */
    public JIFThongtin() throws PropertyVetoException {
        
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
        jButtonThongTinXB = new javax.swing.JButton();
        jButtonLoaiSach = new javax.swing.JButton();
        jButtonTacGia = new javax.swing.JButton();
        jButtonLinhVuc = new javax.swing.JButton();

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
        jLabelTieuDe.setText("Lưu trữ thông tin");

        jButtonThongTinXB.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/people2.png"))); // NOI18N
        jButtonThongTinXB.setText("Thông tin xuất bản");
        jButtonThongTinXB.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonThongTinXB.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonThongTinXBActionPerformed(evt);
            }
        });

        jButtonLoaiSach.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/people3.png"))); // NOI18N
        jButtonLoaiSach.setText("Loại sách");
        jButtonLoaiSach.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonLoaiSach.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonLoaiSachActionPerformed(evt);
            }
        });

        jButtonTacGia.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/book.png"))); // NOI18N
        jButtonTacGia.setText("Tác giả");
        jButtonTacGia.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonTacGia.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonTacGiaActionPerformed(evt);
            }
        });

        jButtonLinhVuc.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Image/list.png"))); // NOI18N
        jButtonLinhVuc.setText("Lĩnh vực");
        jButtonLinhVuc.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButtonLinhVuc.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonLinhVucActionPerformed(evt);
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
                            .addComponent(jButtonTacGia, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButtonLoaiSach, javax.swing.GroupLayout.DEFAULT_SIZE, 229, Short.MAX_VALUE)
                            .addComponent(jButtonThongTinXB, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jButtonLinhVuc, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 229, Short.MAX_VALUE))
                        .addContainerGap())))
        );
        jPanelTainguyenLayout.setVerticalGroup(
            jPanelTainguyenLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanelTainguyenLayout.createSequentialGroup()
                .addComponent(jLabelTieuDe, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonTacGia)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonLoaiSach)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonLinhVuc)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButtonThongTinXB)
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
            .addGap(0, 235, Short.MAX_VALUE)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(layout.createSequentialGroup()
                    .addContainerGap()
                    .addComponent(jPanelTainguyen, javax.swing.GroupLayout.PREFERRED_SIZE, 201, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addContainerGap(23, Short.MAX_VALUE)))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonThongTinXBActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonThongTinXBActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
       // desktop.removeAll();
        ThongTinXB frame;
        try {
            frame = new ThongTinXB();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonThongTinXBActionPerformed

    private void jButtonLoaiSachActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonLoaiSachActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
        //desktop.removeAll();
        LoaiSach frame;
        frame = new LoaiSach();
        frame.setVisible(true);
        getDesktop().add(frame);
        
    }//GEN-LAST:event_jButtonLoaiSachActionPerformed

    private void jButtonTacGiaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonTacGiaActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
            desktop.getComponent(0).setVisible(false);
       // desktop.removeAll();
        TacGia frame;
        try {
            frame = new TacGia();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonTacGiaActionPerformed

    private void jButtonLinhVucActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonLinhVucActionPerformed
        // TODO add your handling code here:
        if(desktop.getComponentCount() != 0)
        desktop.getComponent(0).setVisible(false);
        //desktop.removeAll();
        LinhVuc frame;
        try {
            frame = new LinhVuc();
            frame.setVisible(true);
            getDesktop().add(frame);
            frame.setSelected(true);
        } catch (Exception ex) {
            Logger.getLogger(JIFTainguyen.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonLinhVucActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonLinhVuc;
    private javax.swing.JButton jButtonLoaiSach;
    private javax.swing.JButton jButtonTacGia;
    private javax.swing.JButton jButtonThongTinXB;
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
