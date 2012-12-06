/*
 * Copyright 2004,2006 The Poderosa Project.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 *
 * $Id: SerialPluginEx.cs,v 1.3 2012/03/18 11:02:30 kzmi Exp $
 */
using System;
using System.Collections.Generic;
using System.Text;
using Poderosa.Util;

namespace Poderosa.SerialPort {
    //�V���A���ɕK�v��Enum
    /// <summary>
    /// <ja>�t���[�R���g���[���̐ݒ�</ja>
    /// <en>Specifies the flow control.</en>
    /// </summary>
    /// <exclude/>
    public enum FlowControl {
        /// <summary>
        /// <ja>�Ȃ�</ja>
        /// <en>None</en>
        /// </summary>
        [EnumValue(Description = "Enum.FlowControl.None")]
        None,
        /// <summary>
        /// X ON / X OFf
        /// </summary>
        [EnumValue(Description = "Enum.FlowControl.Xon_Xoff")]
        Xon_Xoff,
        /// <summary>
        /// <ja>�n�[�h�E�F�A</ja>
        /// <en>Hardware</en>
        /// </summary>
        [EnumValue(Description = "Enum.FlowControl.Hardware")]
        Hardware
    }

    /// <summary>
    /// <ja>�p���e�B�̐ݒ�</ja>
    /// <en>Specifies the parity.</en>
    /// </summary>
    /// <exclude/>
    public enum Parity {
        /// <summary>
        /// <ja>�Ȃ�</ja>
        /// <en>None</en>
        /// </summary>
        [EnumValue(Description = "Enum.Parity.NOPARITY")]
        NOPARITY = 0,
        /// <summary>
        /// <ja>�</ja>
        /// <en>Odd</en>
        /// </summary>
        [EnumValue(Description = "Enum.Parity.ODDPARITY")]
        ODDPARITY = 1,
        /// <summary>
        /// <ja>����</ja>
        /// <en>Even</en>
        /// </summary>
        [EnumValue(Description = "Enum.Parity.EVENPARITY")]
        EVENPARITY = 2
        //MARKPARITY  =        3,
        //SPACEPARITY =        4
    }

    /// <summary>
    /// <ja>�X�g�b�v�r�b�g�̐ݒ�</ja>
    /// <en>Specifies the stop bits.</en>
    /// </summary>
    /// <exclude/>
    public enum StopBits {
        /// <summary>
        /// <ja>1�r�b�g</ja>
        /// <en>1 bit</en>
        /// </summary>
        [EnumValue(Description = "Enum.StopBits.ONESTOPBIT")]
        ONESTOPBIT = 0,
        /// <summary>
        /// <ja>1.5�r�b�g</ja>
        /// <en>1.5 bits</en>
        /// </summary>
        [EnumValue(Description = "Enum.StopBits.ONE5STOPBITS")]
        ONE5STOPBITS = 1,
        /// <summary>
        /// <ja>2�r�b�g</ja>
        /// <en>2 bits</en>
        /// </summary>
        [EnumValue(Description = "Enum.StopBits.TWOSTOPBITS")]
        TWOSTOPBITS = 2
    }
}
